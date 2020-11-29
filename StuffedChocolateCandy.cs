using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Hw2M2
{
    class StuffedChocolateCandy : ChocolateCandy
    {
        private string stuffing;
        public string Stuffing
        {
            get { return stuffing; }
            set { if (value.Length != 0) stuffing = value; }
        }
        public StuffedChocolateCandy(double weightOfCandy,double percentageOfCocoa , string stuffing) : base(weightOfCandy, percentageOfCocoa) {
            Stuffing = stuffing;
        }
    }
}
