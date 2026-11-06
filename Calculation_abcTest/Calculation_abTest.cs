using lr01.net;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Calculation_abcTest {
    [TestClass]
    public class Calculation_abTest {
        [TestMethod]
        public void CorrectSum()
        {
            var calc = new Calculation_ab(1, 20);
            Assert.AreEqual(44L, calc.Calculate());
        }

        [TestMethod]
        public void NoMatchingNumbers()
        {
            var calc = new Calculation_ab(3, 7);
            Assert.AreEqual(0L, calc.Calculate());
        }

        [TestMethod]
        public void OneMatchingNumber()
        {
            var calc = new Calculation_ab(2, 2);
            Assert.AreEqual(2L, calc.Calculate());
        }

        [TestMethod]
        public void InvalidInterval()
        {
            var calc = new Calculation_ab(20, 1);
            Assert.ThrowsException<ArgumentException>(
                () => calc.Calculate());
        }

        [TestMethod]
        public void DefaultConstructor()
        {
            var calc = new Calculation_ab();
            Assert.AreEqual(0L, calc.Calculate());
        }

        [TestMethod]
        public void OneParameterConstructor()
        {
            var calc = new Calculation_ab(8);
            Assert.AreEqual(8L, calc.Calculate());
        }
    }
}