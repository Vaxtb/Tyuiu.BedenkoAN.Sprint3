using Tyuiu.BedenkoAN.Sprint3.Task7.V2.Lib;
namespace Tyuiu.BedenkoAN.Sprint3.Task7.V2.Test
{
    [TestClass]
    public sealed class DataServiceTest
    {
        [TestMethod]
        public void TestMethod1()
        {
            double[] wait = new double[] { 59.49, 38.47, -2.81, -19.67, -8.42, 0.57, -6.30, -20.14, -3.51, 38.13, 59.60 };
            int start = -5, stop = 5;
            DataService ds = new DataService();
            double[] res = ds.GetMassFunction(start,stop);
            CollectionAssert.AreEqual(wait,res );

        }
    }
}
