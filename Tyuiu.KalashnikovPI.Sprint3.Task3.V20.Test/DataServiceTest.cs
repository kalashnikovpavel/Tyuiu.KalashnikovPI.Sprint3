using Tyuiu.KalashnikovPI.Sprint3.Task3.V20.Lib;
namespace Tyuiu.KalashnikovPI.Sprint3.Task3.V20.Test
{
    [TestClass]
    public class DataServiceTest
    {
        [TestMethod]
        public void TestMethod1()
        {
            DataService ds = new DataService();

            string str = "gfft ntf f opf";
            char ch = 'f';

            double res = ds.GetCharCount(str, ch);

            int wait = 5;

            Assert.AreEqual(wait,res);
        }
    }
}