using System;
using ffff;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace UnitTestCalc
{
    [TestClass]
    public class UnitTest1
    {
        [TestMethod]
        public void TestMethodSum()
        {
            // Arrange: устанавливает начальные условия для выполнения теста
            decimal a = 2;
            char b = '+';
            decimal c = -3;
            decimal answer = -1;

            // Act: выполняет тест (обычно представляет одну строку кода)
            var factAnswer = Calculator.Calc(a, b, c);

            // Assert: верифицирует результат теста          
            Assert.AreEqual(answer, factAnswer);
        }

        [TestMethod]
        public void TestMethodSubtraction()
        {
            // Arrange: устанавливает начальные условия для выполнения теста
            decimal a = 14;
            char b = '-';
            decimal c = -3;
            decimal answer = 17;

            // Act: выполняет тест (обычно представляет одну строку кода)
            var factAnswer = Calculator.Calc(a, b, c);

            // Assert: верифицирует результат теста          
            Assert.AreEqual(answer, factAnswer);
        }

        [TestMethod]
        public void TestMethodMultiplication()
        {
            // Arrange: устанавливает начальные условия для выполнения теста
            decimal a = 123456;
            char b = '*';
            decimal c = 0;
            decimal answer = 0;

            // Act: выполняет тест (обычно представляет одну строку кода)
            var factAnswer = Calculator.Calc(a, b, c);

            // Assert: верифицирует результат теста          
            Assert.AreEqual(answer, factAnswer);
        }

        [TestMethod]
        public void TestMethodDivision()
        {
            // Arrange: устанавливает начальные условия для выполнения теста
            decimal a = 12;
            char b = '/';
            decimal c = -3;
            decimal answer = -4;

            // Act: выполняет тест (обычно представляет одну строку кода)
            var factAnswer = Calculator.Calc(a, b, c);

            // Assert: верифицирует результат теста          
            Assert.AreEqual(answer, factAnswer);
        }
    }
}