using ExamplePlay;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace UnitTestProject1
{
    [TestClass]
    public class ExampleTests
    {
        Example ex = new Example();
        [TestMethod]
        public void TrimRemovedTest()
        {
            //Arrange
            var value = " Hakan Şahin   ";
            var waitingValue= "Hakan Şahin";

            //Act
            var testFunction = ex.TrimRemoved(value);

            //Assert
            Assert.AreEqual(waitingValue, testFunction);
        }
    }
}
