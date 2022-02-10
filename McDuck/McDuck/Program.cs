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
            firstloop();
            //destructall();
            //firstloop();
            void firstloop()
            {
                for (int i = 0; i < ducks.Length; i++)
                {
                    Console.WriteLine(ducks[i].PerformFly());
                    Console.WriteLine(ducks[i].PerformQuack());
                    Console.WriteLine(ducks[i].Swim());
                    Console.WriteLine(ducks[i].Display());
                    Console.WriteLine("input something to continue");
                    Console.ReadLine();
                }
            }
            //void destructall()
            //{
            //    for (int i = 0; i < ducks.Length; i++)
            //    {
            //        ducks[i].setFlyBeahvior(ducks[i]);
            //        ducks[i].setQuackBehavior();
            //    }
            //}
            
        }
    }
}
