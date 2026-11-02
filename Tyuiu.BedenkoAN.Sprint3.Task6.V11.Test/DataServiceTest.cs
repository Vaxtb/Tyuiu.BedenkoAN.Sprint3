using Tyuiu.BedenkoAN.Sprint3.Task6.V11.Lib;
namespace Tyuiu.BedenkoAN.Sprint3.Task6.V11.Test
{
    [TestClass]
    public sealed class DataServiceTest
    {
        [TestMethod]
        public void TestMethod1()
        {
            int start = 10, stop =19;
            DataService ds = new DataService();
            int res = ds.GetSumTheDivisors(start, stop);
            Assert.AreEqual(9, res);
        }
    }
}
