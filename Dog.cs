using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BaseKeywordPOC
{
    class Dog : Animal
    {
        string color = "black";

        public void showColor()
        {
            Console.WriteLine("Animal class colour:" + base.color);
            Console.WriteLine("Dog class colour:" + color);
        }

        public override void eat()
        {
            base.eat();
            Console.WriteLine("Eating bread...");
        }
        public Dog()
        {
            Console.WriteLine("Dog...");
        }
    }
}
