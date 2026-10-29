using Tyuiu.BedenkoAN.Sprint3.Task2.V6.Lib;
namespace Tyuiu.BedenkoAN.Sprint3.Task2.V6.Test
{
    [TestClass]
    public sealed class DataServiceTest
    {
        [TestMethod]
        public void TestMethod1()
        {
            double a = 0.25;
            int start = 1;
            int end = 10;
            DataService ds = new DataService();
            double res = ds.GetMultiplySeries(a, start, end);

            Assert.AreEqual(0.019, res);
        }
    }
}
