using Tyuiu.BarabashMI.Sprint3.Task1.V24.Lib;
namespace Tyuiu.BarabashMI.Sprint3.Task1.V24.Test
{
    [TestClass]
    public sealed class DataServiceTest
    {
        [TestMethod]
        public void TestMethod1()
        {
            DataService ds = new DataService();
            double wait = 0.186;
            double res = ds.GetSumSeries(5, 1, 12);
            Assert.AreEqual(wait, res);
        }
    }
}
