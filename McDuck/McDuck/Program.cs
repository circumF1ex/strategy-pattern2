using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using DucksClasses;

namespace McDuck
{
    internal class Program
    {
        static void Main(string[] args)
        {
            MallardDuck Miles = new MallardDuck();
            RedheadDuck Raily = new RedheadDuck();
            RubberDuck Ruby = new RubberDuck();
            DecoyDuck Deccart = new DecoyDuck();

            Duck[] ducks = new Duck[] { Miles, Raily, Ruby, Deccart };

            for (int i = 0; i < ducks.Length; i++)
            {
                ducks[i].PerformFly();
                ducks[i].PerformQuack();
                ducks[i].Swim();
                ducks[i].Display();
                Console.ReadKey();
            }
            
        }
    }
}
