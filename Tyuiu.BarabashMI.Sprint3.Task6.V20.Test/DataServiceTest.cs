using Tyuiu.BarabashMI.Sprint3.Task6.V20.Lib;
namespace Tyuiu.BarabashMI.Sprint3.Task6.V20.Test
{
    [TestClass]
    public sealed class DataServiceTest
    {
        [TestMethod]
        public void TestMethod1()
        {
            DataService ds = new DataService();
            int wait = 41;
            int res = ds.GetSumTheDivisors(20, 32);
            Assert.AreEqual(wait, res);
        }
    }
}
