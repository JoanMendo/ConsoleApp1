using Ex4;

namespace TestProject2
{
    [TestClass]
    public class ProgramTest
    {
        [TestMethod]
        public void TestPositives()
        {


            decimal amplitud = 6, altura = 5;

            decimal result = Ex4.program.Rectangle(amplitud, altura);

            Assert.AreEqual(30, result);
        }
        [TestMethod]
        public void TestNegatives()
        {


            decimal amplitud = -6, altura = -5;

            decimal result = Ex4.program.Rectangle(amplitud, altura);

            Assert.AreEqual(30, result);
        }
        [TestMethod]
        public void TestZero()
        {


            decimal amplitud = 6, altura = 0;

            decimal result = Ex4.program.Rectangle(amplitud, altura);

            Assert.AreEqual(0, result);
        }
    }
}
