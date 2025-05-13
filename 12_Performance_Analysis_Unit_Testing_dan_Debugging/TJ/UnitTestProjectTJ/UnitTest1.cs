using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using Tjmodul12_2311104049;

namespace UnitTestProjectTJ
{
    [TestClass]
    public class UnitTest1
    {
        [TestMethod]
        public void TestPangkatPositif()
        {
            var form = new Form1();
            int result = form.CariNilaiPangkat(2, 3);
            Assert.AreEqual(8, result);
        }

        [TestMethod]
        public void TestEksponenNol()
        {
            var form = new Form1();
            int result = form.CariNilaiPangkat(5, 0);
            Assert.AreEqual(1, result);
        }

        [TestMethod]
        public void TestEksponenNegatif()
        {
            var form = new Form1();
            int result = form.CariNilaiPangkat(5, -3);
            Assert.AreEqual(-1, result);
        }

        [TestMethod]
        public void TestInputMelebihiBatas()
        {
            var form = new Form1();
            int result = form.CariNilaiPangkat(101, 2);
            Assert.AreEqual(-2, result);
        }
    }
}
