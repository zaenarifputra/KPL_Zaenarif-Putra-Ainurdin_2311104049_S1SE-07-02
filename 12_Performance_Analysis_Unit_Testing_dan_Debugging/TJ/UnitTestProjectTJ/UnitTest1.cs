using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using Tjmodul12_2311104049;

namespace UnitTestPangkat
{
    [TestClass]
    public class UnitTest1
    {
        [TestMethod]
        public void TestPangkatNormal()
        {
            Assert.AreEqual(8, HitungHelper.CariNilaiPangkat(2, 3));
        }

        [TestMethod]
        public void TestPangkat0()
        {
            Assert.AreEqual(1, HitungHelper.CariNilaiPangkat(0, 0));
        }

        [TestMethod]
        public void TestPangkatNegatif()
        {
            Assert.AreEqual(-1, HitungHelper.CariNilaiPangkat(3, -1));
        }

        [TestMethod]
        public void TestBPangkatLebihDari10()
        {
            Assert.AreEqual(-2, HitungHelper.CariNilaiPangkat(2, 11));
        }

        [TestMethod]
        public void TestANilaiLebihDari100()
        {
            Assert.AreEqual(-2, HitungHelper.CariNilaiPangkat(101, 2));
        }

        [TestMethod]
        public void TestOverflow()
        {
            Assert.AreEqual(-3, HitungHelper.CariNilaiPangkat(99999, 10));
        }
    }
}
