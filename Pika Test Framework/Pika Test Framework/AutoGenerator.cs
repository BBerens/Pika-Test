using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;
using System.Xml.Linq;
using Pika_Test_Framework;
using Newtonsoft.Json;




namespace Pika_Test_Framework
{
    class AutoGenerator
    {
        private string rootDirectory;
        private List<FileInfo> testFiles;
        PikaDBDataSet pikaDBDataSet;

        public AutoGenerator(string inDirectory, PikaDBDataSet PikaDBDataSet)
        {
            pikaDBDataSet = PikaDBDataSet;
            rootDirectory = inDirectory;
            testFiles = new List<FileInfo>();
        }

        public string RootDirectory
        {
            get
            {
                return rootDirectory;
            }
            set
            {
                rootDirectory = value;
            }
        }

        private static XElement GetDirectory(DirectoryInfo dir, List<FileInfo> testFiles)
        {
            var info = new XElement("dir",
                new XAttribute("name", dir.Name));
            if (dir.Exists)
            {
                try
                {
                    foreach (var file in dir.GetFiles("*.???.txt"))
                    {
                        info.Add(new XElement("file",
                            new XAttribute("name", file.Name), new XAttribute("created", file.CreationTime.ToShortDateString()), new XAttribute("modified", file.LastWriteTime), new XAttribute("filepath", file.FullName)));
                        testFiles.Add(file);
                    }

                    foreach (var subdir in dir.GetDirectories())
                    {
                        info.Add(GetDirectory(subdir, testFiles));
                    }
                }
                catch {; }
            }

            return info;
        }


        public void FindNewTestFiles(PikaDBDataSet.NewKayakFileTableDataTable testsDT, int baselineID)
        {
            PikaDBDataSet.KayakFilesDataTable filesDT;
            string description;
            var dir = new DirectoryInfo(rootDirectory);
            var doc = GetDirectory(dir, testFiles);
            doc.Save("dirStructure.xml");
            testsDT.Clear();
            foreach (FileInfo file in testFiles)
            {
                PikaDBDataSetTableAdapters.KayakFilesTableAdapter kayakFilesTableAdapter = new PikaDBDataSetTableAdapters.KayakFilesTableAdapter();
                filesDT = kayakFilesTableAdapter.GetDataByFileName(baselineID, file.FullName);
                if (filesDT.Count == 0)
                {
                    string fileStr = File.ReadAllText(file.FullName);

                    description = GetFirstInstance<string>("Description", fileStr);
                    if (string.IsNullOrEmpty(description))
                        description = "";
                    testsDT.AddNewKayakFileTableRow(file.Name.TrimEnd('\''), file.FullName, description, file.CreationTime, file.LastWriteTime); // New file -> Add
                }
                else if (filesDT.Count == 1)
                    ; // File already exists in DB. Check if this is a newer copy
                else
                    ; // Something is wrong and more than one file in DB have the same filepath
            }
        }

        /*private void LoadElements(XElement xElem)
        {

            foreach (XElement element in xElem.Elements())
            {
                if (element.HasElements)
                {
                    if (element.FirstAttribute != null)
                    {
                        LoadElements(element);
                    }
                    else
                    {
                        LoadElements(element);
                    }
                }
                else
                    treeNode.Nodes.Add(element.FirstAttribute.Value);
            }

        }*/

        public T GetFirstInstance<T>(string propertyName, string json)
        {
            using (var stringReader = new StringReader(json))
            using (var jsonReader = new JsonTextReader(stringReader))
            {
                while (jsonReader.Read())
                {
                    if (jsonReader.TokenType == JsonToken.PropertyName
                        && (string)jsonReader.Value == propertyName)
                    {
                        jsonReader.Read();

                        var serializer = new JsonSerializer();
                        return serializer.Deserialize<T>(jsonReader);
                    }
                }
                return default(T);
            }
        }
    }
}
