using System;
using DioRpg.src.Entities;

namespace DioRpg
{
    class Program
    {
        static void Main(string[] args)
        {
            Hero charactres = new Hero("Chrono", 25, "Archer");
            Hero wizard = new Wizard("Garland", 99, "Magic");
            
            Console.WriteLine(wizard.Power(8));
            Console.WriteLine(wizard.Power(1));
        }
    }
}
