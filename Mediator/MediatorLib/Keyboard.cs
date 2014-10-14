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
        }
        public void Enabled()
        {
            Console.WriteLine("Keyboard enabled!");
            _mediator.KeyboardKeyPressed();
        }

        public void Disabled()
        {
            Console.WriteLine("Keyboard disabled!");
        }
    }
}
