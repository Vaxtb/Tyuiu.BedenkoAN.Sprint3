using Tyuiu.BedenkoAN.Sprint3.Task3.V11.Lib;
namespace Tyuiu.BedenkoAN.Sprint3.Task3.V11.Test
{
    [TestClass]
    public sealed class DataServiceTest
    {
        [TestMethod]
        public void TestMethod1()
        {
            string s = "qqwqw";
            char b = 'q';
            char c = '7';
            DataService ds = new DataService();
            string res = ds.ReplaceCharOnNum(s, b, c);
            Assert.AreEqual("77w7w", res);




        }
    }
}
