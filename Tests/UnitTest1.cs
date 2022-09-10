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

            newNumber = numberRandomizer.Next();
            expectedResult = Convert.ToString(newNumber, 2);
            actualResult = Task1.GetBinaryNumber(newNumber);
            Assert.AreEqual(expectedResult, actualResult);
        }

        [TestMethod]
        public void Test_RemoveDuplicatesFunction_Task2()
        {
            string expectedResult = "A B A C FD"; //Ожидаемый результат
            string actualResult; //Актуальный результат

            actualResult = Task2.RemoveDuplicates("AAA BBB  AAA CC FD");
            Assert.AreEqual(expectedResult, actualResult);
        }
    }
}
