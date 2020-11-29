using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Hw2M2
{
    class Program
    {
        static void Main(string[] args)
        {
            var candy = new StuffedChocolateCandy(5.5, 50, "Nut");
            candy.GetChocolateType(50);
            Console.ReadKey();
        }
    }
}
