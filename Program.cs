using System;

namespace FlowerShop
{
    class Program
    {
        static void Main(string[] args)
        {
            FlowerShop GoldenrodFlowers = new FlowerShop ();
            GoldenrodFlowers.MakeMothersDayArragement()
            .ForEach(flower => Console.WriteLine(flower)) ;
            GoldenrodFlowers.MakeBirthDayArragement()
            .ForEach(flower => Console.WriteLine(flower)) ;
        }
    }
}