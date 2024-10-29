using Tyuiu.KalashnikovPI.Sprint3.Task0.V28.Lib;
namespace Tyuiu.KalashnikovPI.Sprint3.Task0.V28.Test
{
    [TestClass]
    public class DataServiceTest
    {
        [TestMethod]
        public void TestMethod1()
        {
            DataService ds = new DataService();
            double value = 5;
            int startvalue = 1;
            int stopvalue = 10;

            double res = ds.GetMultiplySeries(value, startvalue, stopvalue);

            double wait = 1.1805916207174113E+21;
            Assert.AreEqual(wait, res);
        }
    }
}