using tyuiu.cources.programming.interfaces.Sprint3;
namespace Tyuiu.KalashnikovPI.Sprint3.Task1.V14.Lib
{
    public class DataService : ISprint3Task1V14
    {
        public double GetSumSeries(double value, int startValue, int stopValue)
        {
            double s = 0;
            while(startValue <= stopValue)
            {
                s = s + (Math.Pow(value, startValue) + (1 / (startValue + 1.0))) * Math.Cos(value);
                startValue++;
            }
            return Math.Round(s, 3);
             
        }
    }
}
