using tyuiu.cources.programming.interfaces.Sprint3;
namespace Tyuiu.KalashnikovPI.Sprint3.Task6.V28.Lib
{
    public class DataService : ISprint3Task6V28
    {
        public int GetSumTheDivisors(int startValue, int stopValue)
        {
            int x;
            int s = 0;
            for (x = startValue; x <= stopValue; x++)
            {
                for (int d = 1; d <= x; d++)
                {
                    if ((x % d == 0) & (d <= 7))
                    {
                        s += d;
                    }
                }
            }
            return s;
        }
    }
}
