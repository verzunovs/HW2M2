using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Hw2M2
{
    class CaramelCandy : Candy
    {
        public string FlavourOfCandy { get; }
        public CaramelCandy(double weightOfCandy, string nameOfCandy, string flavourOfCandy) : base(weightOfCandy, nameOfCandy)
        {
            FlavourOfCandy = flavourOfCandy;
        }
    }
}
