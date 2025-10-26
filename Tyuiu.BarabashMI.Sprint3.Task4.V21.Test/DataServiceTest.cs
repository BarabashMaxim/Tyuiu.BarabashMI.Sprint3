using Tyuiu.BarabashMI.Sprint3.Task4.V21.Lib;
namespace Tyuiu.BarabashMI.Sprint3.Task4.V21.Test
{
    [TestClass]
    public sealed class DataServiceTest
    {
        [TestMethod]
        public void TestMethod1()
        {
            DataService ds = new DataService();
            double wait = 0.586;
            double res = ds.Calculate(-5, 5);
            Assert.AreEqual(wait, res);
        }
    }
}
