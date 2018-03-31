using System;

namespace OOP_Examples.Classes.zoo
{
    abstract class Bird : Animals
    {
        public override void CleanUp()
        {
            Console.WriteLine("Somebody else's job");
        }

        public override void Bury()
        {
            Console.WriteLine("See 'CleanUp'");
        }
    }
}

