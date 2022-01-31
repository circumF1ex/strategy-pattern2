using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using DucksClasses;

namespace McDucky
{
    public class Program
    {
        static void Main(string[] args)
        {
            MallardDuck Ducky = new MallardDuck();
            RedheadDuck Duckk = new RedheadDuck();

            Duck[] ducks = new Duck[] { Ducky, Duckk };

            for (int i = 0; i<ducks.Length; i++)
            {
                Console.WriteLine(ducks[i].Quack());
                Console.WriteLine(ducks[i].Swim());
                Console.WriteLine(ducks[i].Display() + $"\n");
                Console.ReadLine();
            }   
        }
    }
}
