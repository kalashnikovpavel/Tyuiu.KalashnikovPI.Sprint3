using Tyuiu.KalashnikovPI.Sprint3.Task1.V14.Lib;
namespace Tyuiu.KalashnikovPI.Sprint3.Task1.V14.Test
{
    [TestClass]
    public class DataServiceTest
    {
        [TestMethod]
        public void TestMethod1()
        { 
            DataService ds = new DataService();

            double value = 0.17;
            int startValue = 1;
            int stopValue = 14;

            double res = ds.GetSumSeries(value, startValue, stopValue);

            double wait = 2,486677941418684;

            Assert.AreEqual(wait, res);
        }
    }
}