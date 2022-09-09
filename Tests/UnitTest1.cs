using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using SaberInteractiveTest;

namespace Tests
{
    [TestClass]
    public class UnitTest1
    {
        [TestMethod]
        public void Test_GetBinaryNumberFunction_Task1()
        {
            Random numberRandomizer = new Random();
            int newNumber;

            string expectedResult; //Ожидаемый результат
            string actualResult; //Актуальный результат

            newNumber = numberRandomizer.Next(0, 100);
            expectedResult = Convert.ToString(newNumber, 2);
            actualResult = Task1.GetBinaryNumber(newNumber);
            Assert.AreEqual(expectedResult, actualResult);
        }
    }
}
