using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Hw2M2
{
    class StuffedChocolateCandy : ChocolateCandy
    {
        //private string stuffing;
        public string Stuffing {get;}
        public StuffedChocolateCandy(double weightOfCandy, string name, double percentageOfCocoa , string stuffing) 
            : base(weightOfCandy,name,percentageOfCocoa) 
        {
            Stuffing = stuffing;
        }
        public void GetStuffing()
        {
            Console.WriteLine($"It is {Stuffing}");
        }
    }
}
