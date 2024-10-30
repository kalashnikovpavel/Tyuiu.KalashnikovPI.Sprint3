using Tyuiu.KalashnikovPI.Sprint3.Task7.V21.Lib;
namespace Tyuiu.KalashnikovPI.Sprint3.Task7.V21.Test
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

            int len = stopValue - startValue + 1;

            double[] valueWaitArray;
            valueWaitArray = new double[len];

            valueWaitArray[0] = 22.87;
            valueWaitArray[1] = 21.96;
            valueWaitArray[2] = 17.98;
            valueWaitArray[3] = 12.42;
            valueWaitArray[4] = 8;
            valueWaitArray[5] = 5;
            valueWaitArray[6] = 1.08;
            valueWaitArray[7] = -5.25;
            valueWaitArray[8] = -11.96;
            valueWaitArray[9] = -15.27;
            valueWaitArray[10] = -14.30;

            double[] res;
            res = new double[len];
            res = ds.GetMassFunction(startValue, stopValue);
            CollectionAssert.AreEqual(valueWaitArray, res);





        }
    }
}