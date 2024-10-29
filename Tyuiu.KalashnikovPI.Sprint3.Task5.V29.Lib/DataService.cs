using tyuiu.cources.programming.interfaces.Sprint3;
namespace Tyuiu.KalashnikovPI.Sprint3.Task5.V29.Lib
{
    public class DataService : ISprint3Task5V29
    {
        public double GetSumSumSeries(int x, int startValue1, int startValue2, int stopValue1, int stopValue2)
        {
            double s = 0;
            int i, j;
            for (i = startValue1; i <= stopValue1; i++)
            {
                for(j = startValue2; j <= stopValue2; j++)
                {
                    s += ((x / startValue2) + Math.Sin(x));
                }
            }
            return Math.Round(s, 3);
        }
    }
}
