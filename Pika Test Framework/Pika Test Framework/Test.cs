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
        private int id;
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
            this.Id = -1;
            this.dateCreated = DateTime.Now;
            this.dateModified = DateTime.Now;
            this.runs = new List<Run>();
            this.labels = new List<Label>();
            
        }

        public Test(PikaDBDataSet.TestsRow row)
        {
            this.Id = row.ID;
            this.Name = row.Name;
            this.Type = row.Type;
            this.FileName = row.FileName;
            this.Description = row.Description.ToString();
            this.DateCreated = row.DateCreated;
            this.DateModified = row.DateModified;
            this.runs = new List<Run>();
            this.labels = new List<Label>();

        }

        public int Id
        {
            get
            {
                return id;
            }
            set
            {
                id = value;
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
            PikaDBDataSet.TestsRow dataRow = PikaDBDataSetTableAdapters.TestsTableAdapter
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
