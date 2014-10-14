using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MediatorLib
{
    public class ComputerSystem
    {
        private Screen screen;
        private Computer computer;
        private Keyboard keyboard;
        public void ComputerSwitchedOn()
        {
            Console.WriteLine("Welcome");
        }

        public void ComputerSwitchedOff()
        {
            Console.WriteLine("Goodbye");
        }

        public void KeyboardKeyPressed(string message)
        {
            screen.OutPut(message);
            

        }

        public void RegisterComputer(Computer computer)
        {
            this.computer = computer;
       
        }

        public void RegisterKeyboard(Keyboard keyboard)
        {
            this.keyboard = keyboard;

        }

        public void RegisterScreen(Screen screen)
        {
            this.screen = screen;
        }
    }
}
