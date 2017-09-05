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
        private string id;
        private string name;
        private int baseline;
        private string type;
        private string fileName;
        private string description;
        DateTime dateCreated;
        DateTime dateModified;
        List<Run> runs;
        List<TestLabel> testLabels;

        public Test()
        {
            this.dateCreated = DateTime.Now;
            this.dateModified = DateTime.Now;
            this.runs = new List<Run>();
            this.testLabels = new List<TestLabel>();
            
        }

        public string Id
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
