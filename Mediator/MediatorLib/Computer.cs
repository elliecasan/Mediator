using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MediatorLib
{
    public class Computer
    {
        private ComputerSystem _mediator;

        public Computer(ComputerSystem mediator)
        {
            _mediator = mediator;
        }

        public void SwitchOn()
        {
            Console.WriteLine("Computer switched on!");
            _mediator.ComputerSwitchedOn();
        }

        public void SwichdOff()
        {
            Console.WriteLine("Computor is switched off!");
            _mediator.ComputerSwitchedOff();
        }
    }
}
