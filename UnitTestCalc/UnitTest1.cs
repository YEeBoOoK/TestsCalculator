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
            decimal a = 1;
            char b = '+';
            decimal c = -3;
            decimal answer = -2;

            // Act: выполняет тест (обычно представляет одну строку кода)
            var factAnswer = Calculator.Calc(a, b, c);

            // Assert: верифицирует результат теста          
            Assert.AreEqual(answer, factAnswer);
        }

        [TestMethod]
        public void TestMethodSubtraction()
        {
            // Arrange: устанавливает начальные условия для выполнения теста
            decimal a = 13;
            char b = '-';
            decimal c = -4;
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
            decimal a = 123;
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
            decimal a = 121;
            char b = '/';
            decimal c = -11;
            decimal answer = -11;

            // Act: выполняет тест (обычно представляет одну строку кода)
            var factAnswer = Calculator.Calc(a, b, c);

            // Assert: верифицирует результат теста          
            Assert.AreEqual(answer, factAnswer);
        }
    }
}