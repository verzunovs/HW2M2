using System;
using System.IO;

namespace Hw2M2
{
    class CandyPackContoler // : IComparable
    {
        public void CreateCandyPack(Candy[] candyPack)
        {
            var rnd = new Random();
            string inputMenuItem;
            int menuItem;
            Console.WriteLine(File.ReadAllText(@"..\..\MenuText.txt"));
            for (int i = 0; i < candyPack.Length; i++)
            {
                Console.WriteLine("Какую конфету хотите добавить?");
                inputMenuItem = Console.ReadLine();
                if (int.TryParse(inputMenuItem, out menuItem))
            {
                
                    
                    if (menuItem == 1) candyPack[i] = new ChocolateCandy(rnd.Next(1, 6), InputData("название конфеты"), rnd.Next(0, 100));
                    if (menuItem == 2) candyPack[i] = new StuffedChocolateCandy(rnd.Next(1, 6), InputData("название конфеты"), rnd.Next(0, 100), InputData("название начинки"));
                    if (menuItem == 3) candyPack[i] = new CaramelCandy(rnd.Next(1, 6), InputData("название конфеты"), InputData("название вкусовой добавки"));
                    if (menuItem == 4) candyPack[i] = new StuffedCaramelCandy(rnd.Next(1, 6), InputData("название конфеты"), InputData("название вкусовой добавки"), InputData("название вкусовой добавки наполнителя"));
                }
            }
        }
        //public void WeightOfPack(Candy []candyPack)
        //{
        //    double weightOfPack=0;
        //    for(int i = 0; i<candyPack.Length; i++)
        //    {
        //        weightOfPack = weightOfPack + candyPack[i].WeightOfCandy;
        //    }
        //    Console.WriteLine($"Weight of candy pack is {weightOfPack}.");
        //}
        private string InputData(string message)
        {
            Console.WriteLine($"Введите {message}.");
            string dataAboutCandy = Console.ReadLine();
            return dataAboutCandy;
        }
    }
}
