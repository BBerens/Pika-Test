using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Xml;
using System.IO;
using System.Collections;


namespace PikaUpdater
{
    class TestXMLParser
    {
        Stream myStream;
        XmlDocument xmlDoc;
        XmlNode root, resultNode;
        IEnumerator testNode;
        string testStart, testEnd, testLab, baseline, baselineVer,
            testMachine, kayakVer, kayakBaselineVer, result, duration, error, fileName;
        string[] metaData;
        List<string[]> runList;



        public TestXMLParser(string path)
        {
            runList = new List<string[]>();
            using (myStream = File.Open(path, FileMode.Open, FileAccess.Read))
            {
                xmlDoc = new XmlDocument();
                xmlDoc.Load(myStream);
                root = xmlDoc.DocumentElement;

                testStart = root.Attributes["Start"].Value;
                testEnd = root.Attributes["End"].Value;
                testLab = root.Attributes["TestLab"].Value;
                baseline = root.Attributes["Baseline"].Value;
                testMachine = root.Attributes["TestMachine"].Value;
                kayakVer = root.Attributes["KayakVer"].Value;
                kayakBaselineVer = root.Attributes["KayakBaselineVer"].Value;


                metaData = new string[] { testLab, baseline, testMachine, kayakVer };

                testNode = root.GetEnumerator();

                while (testNode.MoveNext())
                {
                    fileName = "Non-Test";
                    resultNode = ((XmlNode)testNode.Current).FirstChild;
                    result = resultNode.Attributes["Status"].Value;
                    duration = resultNode.Attributes["Duration"].Value;
                    foreach (XmlNode child in resultNode.ChildNodes)
                    {
                        if (child.Name == "Error")
                        {
                            error = child.InnerText;

                        }
                        else if (child.Name == "Notes")
                        {
                            //parse for the file name
                            string notes = child.InnerText;
                            if (notes.StartsWith("File: "))
                            {
                                fileName = notes.Substring(6, notes.IndexOf('\n') - 6);
                            }

                        }
                    }
                    if (fileName != "Non-Test")
                    {
                        string[] runData = new string[] { testLab, baseline, testMachine, kayakVer, result, duration, error, fileName, testEnd };
                        runList.Add(runData);
                    }
                }
            }
        }

        public List<string[]> GetList()
        {
            return runList;
        }
    }
}
