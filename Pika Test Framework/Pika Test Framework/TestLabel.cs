using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Pika_Test_Framework
{
    

    public class TestLabel
    {
        private int testID { set; get; }
        private int labelID { set; get; }
        private int weight { set; get; }

        public TestLabel(int testID, int labelID, int weight)
        {
            this.testID = testID;
            this.labelID = labelID;
            this.weight = weight;
        }
    }
}
