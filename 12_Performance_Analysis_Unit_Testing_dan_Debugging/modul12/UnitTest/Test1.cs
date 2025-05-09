namespace UnitTest
{
    [TestClass]
    public sealed class Test1
    {
        [TestMethod]
        public void TestMethod1()
        {
        }
        public void TestGrade()
        {
            String? result1 = modul12.Program.DetermineGrade(90);
            Assert.AreEqual("A", result1);

            String? result2 = modul12.Program.DetermineGrade(80);
            Assert.AreEqual("B", result2);

            String? result3 = modul12.Program.DetermineGrade(70);
            Assert.AreEqual("C", result3);

            String? result4 = modul12.Program.DetermineGrade(60);
            Assert.AreEqual("D", result4);

            String? result5 = modul12.Program.DetermineGrade(50);
            Assert.AreEqual("E", result5);

            String? result6 = modul12.Program.DetermineGrade(101);
            Assert.IsNull(result6);

            String? result7 = modul12.Program.DetermineGrade(-1);
            Assert.IsNull(result7);
        }
    }
}
