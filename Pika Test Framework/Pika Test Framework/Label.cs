using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Pika_Test_Framework
{
    public class Label
    {
        private int labelId;
        private int weight;
        private string name;
        //List<TestLabel> testLabels;

        public Label()
        {
            labelId = -1;
            //testLabels = new List<TestLabel>();
        }

        public Label(PikaDBDataSet.TestViewRow row)
        {
            this.LabelId = row.LabelID;
            this.Name = row.LabelName;
            this.Weight = row.Weight;
        }
        public int LabelId
        {
            get
            {
                return labelId;
            }
            set
            {
                labelId = value;
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

        public int Weight
        {
            get
            {
                return weight;
            }
            set
            {
                weight = value;
            }
        }

        public string[] ToArr()
        {
            string[] array = new string[] {Name, Weight.ToString() };
            return array;
        }
    }


}
