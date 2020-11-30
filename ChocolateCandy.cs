using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Hw2M2
{
    class ChocolateCandy : Candy
    {
        private double percentageOfCacao;
        public double PercentageOfCacao
        {
            get { return percentageOfCacao; }
            set { if (value >= 0 && value < 100) percentageOfCacao = value; }
        }

        public ChocolateCandy(double weightOfCandy,string name, double percentageOfCacao) 
            : base(weightOfCandy, name)
        {
            PercentageOfCacao = percentageOfCacao;
        }
        public void GetChocolateType()
        {
            if (PercentageOfCacao >= 35 & PercentageOfCacao < 100) Console.WriteLine($"It is {TypeOfChocolate.Dark} chocolate.");
            if (PercentageOfCacao < 35 & PercentageOfCacao >= 25) Console.WriteLine($"It is {TypeOfChocolate.Milk} chocolate.");
            if (PercentageOfCacao < 25) Console.WriteLine($"It is {TypeOfChocolate.CocoaContainingProduct}.");
            if (PercentageOfCacao == 0) Console.WriteLine($"It is {TypeOfChocolate.White} chocolate;");
        }
    }
}
