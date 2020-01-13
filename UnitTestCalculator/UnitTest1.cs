using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using Sandbox;

namespace UnitTestCalculator
{
    [TestClass]
    public class UnitCalculator
    {
        [TestMethod]
        public void TestAddPOsitiveNumbers()
        {
            //Arrange
            Calculator c = new Calculator();
            int tal1 = 20;
            int tal2 = 30;
            //Act

            int expectedResult = 50;
            int actualResult = c.Add(tal1, tal2);

            //Assert
            Assert.AreEqual(expectedResult, actualResult);

        }

        [TestMethod]
        public void TestAddNegativeNumbers()
        {
            //Arrange
            Calculator c = new Calculator();
            int tal1 = -20;
            int tal2 = -30;
            //Act

            int expectedResult = -50;
            int actualResult = c.Add(tal1, tal2);

            //Assert
            Assert.AreEqual(expectedResult, actualResult);

        }

        [TestMethod]
        public void TestDivisionPositiveNumbers()
        {
            //Arrange
            Calculator c = new Calculator();
            int tal1 = 20;
            int tal2 = 5;
            //Act

            int expectedResult = 4;
            int actualResult = c.Division(tal1, tal2);

            //Assert
            Assert.AreEqual(expectedResult, actualResult);

        }

        [TestMethod]
        [ExpectedException(typeof(DivideByZeroException))]
        public void TestDivisionByZero()
        {
            //Arrange
            Calculator c = new Calculator();
            int tal1 = 20;
            int tal2 = 0;
            int resultat = 0;

            // Act & Assert
            resultat= c.Division(tal1, tal2); 

        }

        [TestMethod]
        [ExpectedException(typeof(TooLargeNumberException))]
        public void TestDivisionByTooLargeNumber()
        {
            //Arrange
            Calculator c = new Calculator();
            int tal1 = 20;
            int tal2 = 200;
            int resultat = 0;

            // Act & Assert
            resultat = c.Division(tal1, tal2);

        }
    }
}