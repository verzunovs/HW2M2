using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Hw2M2
{
    class StuffedCaramelCandy : CaramelCandy
    {
        public string StuffingOfCaramelCandy { get; }
        public StuffedCaramelCandy(double weightOfCandy, string nameOfCandy, string flavourOfCandy, string stuffingOfCaramelCandy) 
            : base(weightOfCandy, nameOfCandy, flavourOfCandy)
        {
            StuffingOfCaramelCandy = stuffingOfCaramelCandy;
        }
    }
}
