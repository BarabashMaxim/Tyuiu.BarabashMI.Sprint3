using Tyuiu.BarabashMI.Sprint3.Task3.V10.Lib;

namespace Tyuiu.BarabashMI.Sprint3.Task3.V10.Test
{
    [TestClass]
    public sealed class DataServiceTest
    {
        [TestMethod]
        public void TestMethod1()
        {
            DataService ds = new DataService();
            string wait = "gdff vft ";
            string res = ds.DeleteCharInString("gdfppf vfppt p", 'p');
            Assert.AreEqual(wait, res);
        }
    }
}
