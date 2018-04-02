using System;
using PokemonZoo;
using PokemonZoo.cs.NewFolder;

namespace PokemonZoo.cs
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Here is displayed a Zoo with a list of 7 Pokemon");
            Console.WriteLine(" Listed Pokemon Name + Health + Attack");
            Console.ReadLine();
            // Console.WriteLine("Listed Next is Pokemon Health");
            // Console.WriteLine("Listed Last is the Attack");



            //charmander
            Charmander l = new Charmander();
            //string ember = l.EmberAttack(); -> Another way to call method 
           // string nonflying = l.Flying();   -> Another longer way to call method
            Console.WriteLine($" {l.Name} + {l.Weakness} + {l.Health}");
            l.Flying();
            l.EmberAttack();
            Console.ReadLine();

            //Warturtle
            // constructor = new instance of class
            Warturtle w = new Warturtle();
            // declaring var to return value of BubbleAttack()
            //string bubbleString= w.BubbleAttack(); -> another way to write call method
            Console.WriteLine($"{w.Name} + {w.Health} + {w.Attack}");
            w.Tackle();
            w.BubbleAttack();
            Console.ReadLine();

            //Charizoid
            Charizoid c = new Charizoid();
            Console.WriteLine($"{c.Name} + {c.Health}+ {c.Attack} + {c.Weakness}");
            c.Flying();
            c.CanEvolve();
            Console.ReadLine();

            //squritle
            Squritle s = new Squritle();
            Console.WriteLine($"{s.Name} + {s.Health}+ {s.Attack}");
            s.Tackle();
            s.BubbleAttack();
            Console.ReadLine();

            //bulbasuar
            Bulbasuar b = new Bulbasuar();
            Console.WriteLine($"{b.Name}+ {b.Health}+ {b.Weakness}");
            b.CanEvolve();
            b.Catchable();
            Console.ReadLine();

            //picachu
            Picachu p = new Picachu();
            Console.WriteLine($"{p.Name} + {p.Health} + {p.Attack}+ {p.Weakness}");
            p.CanEvolve();
            p.Catchable();
            Console.ReadLine();

            //Ivysaur
            Ivysauer i = new Ivysauer();
            Console.WriteLine($"{i.Name} + {i.Health} + {i.Attack}+ {i.Weakness}");
            i.CanEvolve();
            i.Catchable();
            Console.ReadLine();
            Console.ReadKey();

        







        }
    }
}
