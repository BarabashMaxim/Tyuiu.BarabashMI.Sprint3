using Tyuiu.BarabashMI.Sprint3.Task2.V15.Lib;
namespace Tyuiu.BarabashMI.Sprint3.Task2.V15.Test
{
    [TestClass]
    public sealed class DataServiceTest
    {
        [TestMethod]
        public void TestMethod1()
        {
            DataService ds = new DataService();
            double wait = 0.298;
            double res = ds.GetSumSeries(0.5, 1, 20);
            Assert.AreEqual(wait, res);
        }
    }
}
