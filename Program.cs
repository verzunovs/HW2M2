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
            var rnd = new Random();
            var candyPack = new Candy[5];
            candyPack[0] = new CaramelCandy(rnd.Next(1, 6), "Карамельная палочка", "Citrus");
            Console.ReadKey();
        }
    }
}
