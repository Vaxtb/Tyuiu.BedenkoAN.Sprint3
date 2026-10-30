using Tyuiu.BedenkoAN.Sprint3.Task5.V12.Lib;

namespace Tyuiu.BedenkoAN.Sprint3.Task5.V12.Test
{
    [TestClass]
    public sealed class DataServiceTest
    {
        [TestMethod]
        public void TestMethod1()
        {
            int x = 5;
            int s1 = 1;
            int s2 = 3;
            int s3 = 1;
            int s4 = 10;
            DataService ds = new DataService();
            double res = ds.GetSumSumSeries(x, s1, s3, s2, s4);
            Assert.AreEqual(55.748, res);
        }
    }
}
