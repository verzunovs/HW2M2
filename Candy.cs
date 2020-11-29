using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Hw2M2
{
    public class Candy
    {
        private double weightOfCandy;
        public double WeightOfCandy
        {
            get { return weightOfCandy; }
            set { if (weightOfCandy > 0) weightOfCandy = value; }
        }
        public Candy(double weightOfCandy) { WeightOfCandy = weightOfCandy; }
    }
}
