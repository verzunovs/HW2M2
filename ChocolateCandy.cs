using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Hw2M2
{
    class ChocolateCandy : Candy, IGetChocolateType
    {
        private double percentageOfCacao;
        public double PercentageOfCacao
        {
            get { return percentageOfCacao; }
            set { if (value >= 0 && value < 100) percentageOfCacao = value; }
        }

        public ChocolateCandy(double weightOfCandy, double percentageOfCacao) : base(weightOfCandy)
        {
            PercentageOfCacao = percentageOfCacao;
        }
        public void GetChocolateType(double percentageOfCacao)
        {

            if (percentageOfCacao >= 35 & percentageOfCacao < 100) Console.WriteLine($"It is {TypeOfChocolate.Dark} chocolate.");
            if (percentageOfCacao < 35 & percentageOfCacao >= 25) Console.WriteLine($"It is {TypeOfChocolate.Milk} chocolate.");
            if (percentageOfCacao < 25) Console.WriteLine($"It is {TypeOfChocolate.CocoaContainingProduct}.");
            if (percentageOfCacao == 0) Console.WriteLine($"It is {TypeOfChocolate.White} chocolate;");
        }
    }
}
