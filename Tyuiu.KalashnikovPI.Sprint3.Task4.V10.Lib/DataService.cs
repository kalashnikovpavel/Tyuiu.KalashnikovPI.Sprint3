using tyuiu.cources.programming.interfaces.Sprint3;
namespace Tyuiu.KalashnikovPI.Sprint3.Task4.V10.Lib
{
    public class DataService : ISprint3Task4V10
    {
        public double Calculate(int startValue, int stopValue)
        {
            double res = 1;

            for (int x = startValue; x <= stopValue; x++)
            {
                if (x == 0)
                {
                    continue;
                }
                else
                {
                    res *= (Math.Sin(x) - x) / x;
                }
            }
            return res;
        }
    }
}
