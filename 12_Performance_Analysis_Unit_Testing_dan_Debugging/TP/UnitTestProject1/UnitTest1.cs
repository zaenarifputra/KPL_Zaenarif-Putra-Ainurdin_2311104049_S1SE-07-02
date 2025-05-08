using Microsoft.VisualStudio.TestTools.UnitTesting;
using Tpmodul12_2311104049;  // Perhatikan huruf besar T

namespace UnitTestProject1
{
    [TestClass]
    public class UnitTest1
    {
        Form1 form = new Form1();

        [TestMethod]
        public void TestNegatif()
        {
            string result = form.CariTandaBilangan(-5);
            Assert.AreEqual("Negatif", result);
        }

        [TestMethod]
        public void TestPositif()
        {
            string result = form.CariTandaBilangan(7);
            Assert.AreEqual("Positif", result);
        }

        [TestMethod]
        public void TestNol()
        {
            string result = form.CariTandaBilangan(0);
            Assert.AreEqual("Nol", result);
        }
    }
}