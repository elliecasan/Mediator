using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MediatorLib
{
    public class Keyboard
    {
        private ComputerSystem _mediator;
   
        public Keyboard(ComputerSystem mediator)
        {
            _mediator = mediator;
            mediator.RegisterKeyboard(this);
        }

        public void KeyPress(string message)
        {
            _mediator.KeyboardKeyPressed(message);
        }

        public void Enabled()
        {
            Console.WriteLine("Keyboard enabled!");
          
        }

        public void Disabled()
        {
            Console.WriteLine("Keyboard disabled!");
        }
    }
}
