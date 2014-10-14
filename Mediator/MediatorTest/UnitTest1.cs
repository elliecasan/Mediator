using System;
using MediatorLib;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace MediatorTest
{
    [TestClass]
    public class UnitTest1
    {
        [TestMethod]
        public void Test_That_Screen_Produces_Output()
        {
            //Arrange
            ComputerSystem mediator = new ComputerSystem();
            Computer computer= new Computer();
            Keyboard keyboard = new Keyboard();
            Screen screen = new Screen();
            //Act

            //Assert
        }
    }

   
}
