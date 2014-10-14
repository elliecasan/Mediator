using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MediatorLib
{
    public class Screen
    {

        private ComputerSystem _mediator;

        public Screen(ComputerSystem mediator)
        {
            _mediator = mediator;
        }

        public void TurnOn()
        {
            Console.WriteLine("Screen turned on!");
        }

        public void TurnOff()
        {
            Console.WriteLine("Screen is turned off!");
        }
    }
}
