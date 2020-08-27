using System;
using Calculator;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace Calculator_UnitTest
{
    [TestClass]
    public class UnitTest1
    {
        private CalculateClass math = new CalculateClass();
        [TestMethod]
        public void Sum_Test()
        {
            double x = 7;
            double y = 7;
            double exp = 14;

            double real = math.Sum(x, y);
            Assert.AreEqual(exp, real);
        }

        [TestMethod]
        public void Minus_Test()
        {
            double x = 7;
            double y = 7;
            double exp = 0;

            double real = math.Minus(x, y);
            Assert.AreEqual(exp, real);
        }

        [TestMethod]
        public void Multiple_Test()
        {
            double x = 7;
            double y = 7;
            double exp = 49;

            double real = math.Mul(x, y);
            Assert.AreEqual(exp, real);
        }

        [TestMethod]
        public void Divided_Test()
        {
            double x = 7;
            double y = 7;
            double exp = 1;

            double real = math.Div(x, y);
            Assert.AreEqual(exp, real);
        }

        [TestMethod]
        public void Divided_Test_2()
        {
            double x = 7;
            double y = 0;

            double real = math.Div(x, y);
        }
    }
}
