using Tyuiu.BedenkoAN.Sprint3.Task1.V9.Lib;
namespace Tyuiu.BedenkoAN.Sprint3.Task1.V9.Test
{
    [TestClass]
    public sealed class DataServiceTest
    {
        [TestMethod]
        public void TestMethod1()
        {
            int start = 1;
            DataService ds = new DataService();
            int end = 4;
            int x = 5;
            double res = ds.GetMultiplySeries(x, start,end);
            Assert.AreEqual(5815.752, res);
        }
    }
}
