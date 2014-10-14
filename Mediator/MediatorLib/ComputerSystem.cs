using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MediatorLib
{
    public class ComputerSystem
    {
        public void ComputerSwitchedOn()
        {
            Console.WriteLine("Welcome");
        }

        public void ComputerSwitchedOff()
        {
            Console.WriteLine("Goodbye");
        }

        public void KeyboardKeyPressed()
        {
            Console.WriteLine("Key is pressed!");
        }
    }
}
