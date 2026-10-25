using Tyuiu.BedenkoAN.Sprint3.Task0.V19.Lib;
namespace Tyuiu.BedenkoAN.Sprint3.Task0.V19.Test
{
    [TestClass]
    public sealed class DataServiceTest
    {
        [TestMethod]
        public void TestMethod1()
        {
            int start = 1;
            DataService ds = new DataService();
            int end = 10;
            double res = ds.GetSumSeries(start, end);
            Assert.AreEqual(4.399, res);


        }
    }
}
