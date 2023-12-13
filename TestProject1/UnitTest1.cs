using Ex4;

namespace TestProject1
{
    [TestClass]
    public class ProgramTest
    {
        [TestMethod]
        public void TestPositives()
        {


                decimal amplitud = 6, apotema = 5 ;

                decimal result = Ex4.program.Pentagon(amplitud, apotema);

                Assert.AreEqual(75, result);
        }
        [TestMethod]
        public void TestNegatives()
        {


            decimal amplitud = -6, apotema = -5;

            decimal result = Ex4.program.Pentagon(amplitud, apotema);

            Assert.AreEqual(75, result);
        }
        [TestMethod]
        public void TestZero()
        {


            decimal amplitud = -6, apotema = 0;

            decimal result = Ex4.program.Pentagon(amplitud, apotema);

            Assert.AreEqual(0, result);
        }
    }
}