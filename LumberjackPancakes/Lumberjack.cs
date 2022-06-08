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

        public Lumberjack(string name, Stack<Flapjack> flapjackStack)
        {
            Name = name;
            this.flapjackStack = flapjackStack;
        }

        private void TakeFlapjack(Flapjack flapjack)
        {
            flapjackStack.Push (flapjack);
        }

        private void EatFlapjacks()
        {
            Console.WriteLine($"{this.Name} je naleśniki.");
            flapjackStack.Pop ();
            
        }
    }
}
