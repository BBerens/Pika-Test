using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Pika_Test_Framework
{
    class Label
    {
        int labelId;
        string name;
        List<TestLabel> testLabels;

        public Label()
        {
            labelId = -1;
            testLabels = new List<TestLabel>();
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
    }


}
