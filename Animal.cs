using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Nasledovanie
{
    public class Animal
    {
        public static string Name;
        public Animal(string name)
        {
            Name = name;
        }
        public new void Show()
        {
            Console.WriteLine(Name);
        }
        public new void Voice()
        {
            Console.WriteLine("Мычание");
        }
    }
    public class Cat : Animal
    {
        string Color;
        public Cat(string Name, string color) : base(Name)
        {
            Color = color;
        }
        public new void Show()
        {
            Console.WriteLine(Name + " " + Color);
        }
        public new void Voice()
        {
            Console.WriteLine("Мяу-мяу");
        }
    }
    public class Dog : Animal
    {
        string Color;
        public Dog(string Name, string color) : base(Name)
        {
            Color = color;
        }
        public new void Show()
        {
            Console.WriteLine(Name + " " + Color);
        }
        public new void Voice()
        {
            Console.WriteLine("Гав-гав");
        }
    }
}
