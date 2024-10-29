using Tyuiu.KalashnikovPI.Sprint3.Task2.V2.Lib;
namespace Tyuiu.KalashnikovPI.Sprint3.Task2.V2.Test
{
    [TestClass]
    public class DataServiceTest
    {
        [TestMethod]
        public void TestMethod1()
        {
            DataService ds = new DataService();

            int startValue = 1;
            int stopValue = 10;

            double res = ds.GetMultiplySeries(startValue, stopValue);

            double wait = 4825720.722;

            Assert.AreEqual(wait, res);
        }
    }
}