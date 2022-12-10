using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BaseKeywordPOC
{
    class Animal
    {
        public string color = "White";
        public virtual void eat()
        {
            Console.WriteLine("Eating...");
        }
        public Animal()
        {
            Console.WriteLine("Animal...");
        }
    }
}
