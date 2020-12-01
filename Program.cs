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
            var candyPack = new Candy[5];
            var menu = new CandyPackContoler();
            menu.CreateCandyPack(candyPack);
            Console.ReadKey();
        }
    }
}
