using lr01.net;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Calculation_abcTest {
    [TestClass]
    public class TetrahedronTest {
        [TestMethod]
        public void CalculateVolumeTest()
        {
            var t = new Tetrahedron(3);
            double expected = 3.181980515;
            Assert.AreEqual(expected, t.CalculateVolume(), 0.000001);
        }

        [TestMethod]
        public void CalculateHeightTest()
        {
            var t = new Tetrahedron(3);
            double expected = 2.449489743;
            Assert.AreEqual(expected, t.CalculateHeight(), 0.000001);
        }

        [TestMethod]
        public void CalculateSurfaceAreaTest()
        {
            var t = new Tetrahedron(3);
            double expected = 15.588457268;
            Assert.AreEqual(expected, t.CalculateSurfaceArea(), 0.000001);
        }

        [TestMethod]
        public void InvalidEdgeTest()
        {
            Assert.ThrowsException<ArgumentException>(
                () => new Tetrahedron(-3));
        }

        [TestMethod]
        public void ZeroEdgeTest()
        {
            Assert.ThrowsException<ArgumentException>(
                () => new Tetrahedron(0));
        }

        [TestMethod]
        public void DefaultConstructorTest()
        {
            var t = new Tetrahedron();
            Assert.AreEqual(1.0, t.A);
        }

        [TestMethod]
        public void CopyConstructorTest()
        {
            var first = new Tetrahedron(5);
            var second = new Tetrahedron(first);
            Assert.AreEqual(5.0, second.A);
        }
    }
}