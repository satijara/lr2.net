using Microsoft.VisualStudio.TestTools.UnitTesting;
using System;
using lr01.net;

namespace Calculation_abcTest {
    [TestClass]
    public class Calculation_abcTest {
        [TestMethod]
        public void AllGreaterThan3()
        {
            var calc = new Calculation_abc(4, 5, 6);

            Assert.AreEqual(3, calc.Calculate());
        }

        [TestMethod]
        public void TwoGreaterThan3()
        {
            var calc = new Calculation_abc(4, 2, 6);

            Assert.AreEqual(2, calc.Calculate());
        }

        [TestMethod]
        public void OneGreaterThan3()
        {
            var calc = new Calculation_abc(1, 5, 2);

            Assert.AreEqual(1, calc.Calculate());
        }

        [TestMethod]
        public void NoneGreaterThan3()
        {
            var calc = new Calculation_abc(1, 2, 3);

            Assert.AreEqual(0, calc.Calculate());
        }

        [TestMethod]
        public void DefaultConstructor()
        {
            var calc = new Calculation_abc();

            Assert.AreEqual(0, calc.Calculate());
        }

        [TestMethod]
        public void OneParameterConstructor()
        {
            var calc = new Calculation_abc(5);

            Assert.AreEqual(1, calc.Calculate());
        }
    }
}