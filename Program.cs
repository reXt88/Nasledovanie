using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Nasledovanie
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Dog qwe = new Dog("Джек", "коричневый");
            qwe.Show();
            qwe.Voice();
            Cat asd = new Cat("Мурка", "серая");
            asd.Show();
            asd.Voice();
            Console.ReadKey();
        }
    }
}
