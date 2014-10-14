using System;
using MediatorLib;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace MediatorTest
{
    [TestClass]
    public class MediatorTest
    {
        [TestMethod]
        public void Test_That_Screen_Produces_Output()
        {
            //Arrange
            ComputerSystem mediator = new ComputerSystem();
            Computer computer= new Computer(mediator);
            Keyboard keyboard = new Keyboard(mediator);
            Screen screen = new Screen(mediator);
            //Act
            computer.SwitchOn();
            keyboard.KeyPress("Hello");
            //Assert
        }
    }

   
}
