using Tyuiu.BedenkoAN.Sprint3.Task4.V6.Lib;
namespace Tyuiu.BedenkoAN.Sprint3.Task4.V6.Test
{
    [TestClass]
    public sealed class DataServiceTest
    {
        [TestMethod]
        public void TestMethod1()
        {
            int x = -5;
            int z = 5;
            DataService ds = new DataService();
            double res = ds.Calculate(x, z);
            Assert.AreEqual(8.995, res);


        }
    }
}
