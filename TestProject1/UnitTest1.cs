using Ex4;

namespace TestProject1
{
    [TestClass]
    public class UnitTest1
    {
        [TestMethod]
        public void TestMethod1()
        {
            Random rd = new Random();

                decimal amplitud = rd.Next(1, 25), apotema = rd.Next(1, 25);

                decimal result = Ex4.program.Pentagon(amplitud, apotema);

                Assert.AreEqual(((amplitud * 5) * apotema) / 2, result);
            


        }
    }
}