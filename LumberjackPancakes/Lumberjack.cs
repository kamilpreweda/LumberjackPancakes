using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LumberjackPancakes
{
    internal class Lumberjack
    {
        public string Name { get; private set; }
        private Stack<Flapjack> flapjackStack = new Stack<Flapjack> ();

        public Lumberjack(string name)
        {
            Name = name;
            
        }

        public void TakeFlapjack(Flapjack flapjack)
        {
            flapjackStack.Push (flapjack);
        }

        public void EatFlapjacks()
        {
            Console.WriteLine($"{Name} je naleśniki.");
            while (flapjackStack.Count > 0)
            {
                Console.WriteLine($"{Name} je {flapjackStack.Pop().ToString().ToLower()} naleśnik.");
            }
            
        }
    }
}
