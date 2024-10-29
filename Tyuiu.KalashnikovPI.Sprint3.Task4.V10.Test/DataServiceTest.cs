using Tyuiu.KalashnikovPI.Sprint3.Task4.V10.Lib;
namespace Tyuiu.KalashnikovPI.Sprint3.Task4.V10.Test
{
    [TestClass]
    public class DataServiceTest
    {
        [TestMethod]
        public void TestMethod1()
        {
            DataService ds = new DataService();

            int startValue = -5;
            int stopValue = 5;

            double res = ds.Calculate(startValue, stopValue);

            double wait = 0.013634070319817712;

            Assert.AreEqual(wait, res);
        }
    }
}