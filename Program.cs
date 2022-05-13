using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Bil
{
    internal class Program
    {
        static void Main(string[] args)
        {
            var bilar = new List<Car>();
            Console.WriteLine(" Hur många bilar vill du lagra?");
            var antal = UInt32.Parse(Console.ReadLine());

            for (int i = 0; i < antal; i++) ;
            {
                Console.WriteLine("Ange model");
                var model = Console.ReadLine();

                Console.WriteLine("Ange år ");

                if(int.TryParse(Console.ReadLine(), out int year))
                {
                    var bil = new Car(model, year);
                    bilar.Add(bil);
                }
            }

            foreach (var b in bilar) 
            {
                Console.WriteLine (b.ToString());
            }
            

            

        }
    }
}