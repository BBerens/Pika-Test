using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Pika_Test_Framework
{
    public class Test
    {
        private string testId;
        
        private string name;
        private int baseline;
        private string type;
        private string fileName;
        private string description;
        private DateTime dateCreated;
        private DateTime dateModified;
        public List<Run> runs;
        public List<Label> labels;

        public Test()
        {
            this.TestId = "";
            this.dateCreated = DateTime.Now;
            this.dateModified = DateTime.Now;
            this.runs = new List<Run>();
            this.labels = new List<Label>();
            
        }

        public Test(PikaDBDataSet.TestsRow row)
        {
            this.TestId = row.TestID;
            this.Name = row.Name;
            this.Type = row.Type;
            this.FileName = row.FileName;
            this.Description = row.Description.ToString();
            this.DateCreated = row.DateCreated;
            this.DateModified = row.DateModified;
            this.runs = new List<Run>();
            this.labels = new List<Label>();
        }

        public Test(PikaDBDataSet.TestViewDataTable table)
        {
            this.TestId = table[0].TestID;
            this.Name = table[0].Name;
            this.Type = table[0].Type;
            this.FileName = table[0].FileName;
            this.Description = Encoding.ASCII.GetString(table[0].Description);
            this.DateCreated = table[0].DateCreated;
            this.DateModified = table[0].DateModified;
            this.runs = new List<Run>();
            this.labels = new List<Label>();
            foreach (PikaDBDataSet.TestViewRow row in table)
            {
                Label newLabel = new Label(row);
                this.labels.Add(newLabel);
            }
            
        }

        public string TestId
        {
            get
            {
                return testId;
            }
            set
            {
                testId = value;
            }
        }

        public string Name
        {
            get
            {
                return name;
            }
            set
            {
                name = value;
            }
        }

        public int Baseline
        {
            get
            {
                return baseline;
            }
            set
            {
                baseline = value;
            }
        }

        public string Type
        {
            get
            {
                return type;
            }
            set
            {
                type = value;
            }
        }

        public string FileName
        {
            get
            {
                return fileName;
            }
            set
            {
                fileName = value;
            }
        }

        public string Description
        {
            get
            {
                return description;
            }
            set
            {
                description = value;
            }
        }

        public DateTime DateCreated
        {
            get
            {
                return dateCreated;
            }
            set
            {
                dateCreated = value;
            }
        }

        public DateTime DateModified
        {
            get
            {
                return dateModified;
            }
            set
            {
                dateModified = value;
            }
        }

        /*public PikaDBDataSet.TestsRow ToRow()
        {
            PikaDBDataSet.TestsRow dataRow = new PikaDBDataSet.;
            dataRow["name"] = Name;
            dataRow["baseline"] = db.Baselines[baseline].ID;
            dataRow["type"] = Type;
            dataRow["fileName"] = FileName;
            dataRow["dateCreated"] = DateCreated;
            dataRow["dateModified"] = DateModified;

            return dataRow;

        }*/

    }
}
