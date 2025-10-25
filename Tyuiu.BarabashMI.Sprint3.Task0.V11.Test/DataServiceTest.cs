using Tyuiu.BarabashMI.Sprint3.Task0.V11.Lib;
namespace Tyuiu.BarabashMI.Sprint3.Task0.V11.Test
{
    [TestClass]
    public sealed class DataServiceTest
    {
        [TestMethod]
        public void TestMethod1()
        {
            DataService ds = new DataService();
            double wait = 0.042;
            double res = ds.GetSumSeries(5, 1, 10);
            Assert.AreEqual(wait, res);
        }
    }
}
