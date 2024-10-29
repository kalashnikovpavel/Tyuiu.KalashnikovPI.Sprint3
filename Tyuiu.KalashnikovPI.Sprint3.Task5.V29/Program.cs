using Tyuiu.KalashnikovPI.Sprint3.Task5.V29.Lib;
namespace Tyuiu.KalashnikovPI.Sprint3.Task5.V29
{
    internal class Program
    {
        static void Main(string[] args)
        {
            DataService ds = new DataService();

            Console.Title = "Спринт #3 | Выполнил: Калашников П. И. | СМАРТБ-24-1";
            Console.WriteLine("***************************************************************************");
            Console.WriteLine("* Спринт 3                                                                *");
            Console.WriteLine("* Тема: Оператор цикла foreach                                            *");
            Console.WriteLine("* Задание #5                                                              *");
            Console.WriteLine("* Вариант #29                                                             *");
            Console.WriteLine("* Выполнил: Калашников Павел Ильич | СМАРТб-24-1                          *");
            Console.WriteLine("***************************************************************************");
            Console.WriteLine("* УСЛОВИЕ:                                                                *");
            Console.WriteLine("* Рассчитать сумму сумм                                                   *");
            Console.WriteLine("*                                                                         *");
            Console.WriteLine("***************************************************************************");
            Console.WriteLine("* ИСХОДНЫЕ ДАННЫНЕ:                                                       *");
            Console.WriteLine("***************************************************************************");

            int x = 2;
            int startValue1 = 1;
            int startValue2 = 1;
            int stopValue1 = 3;
            int stopValue2 = 10;

            Console.WriteLine("Переменная Х = " + x);
            Console.WriteLine("статрт шага первой суммы = " + startValue1);
            Console.WriteLine("конец шага первой суммы = " + stopValue1);
            Console.WriteLine("страт шага второй суммы = " + startValue1);
            Console.WriteLine("конец шага второй суммы = " + stopValue1);

            Console.WriteLine("***************************************************************************");
            Console.WriteLine("* РЕЗУЛЬТАТ:                                                              *");
            Console.WriteLine("***************************************************************************");

            Console.WriteLine("сумма ряда = " + ds.GetSumSumSeries(x, startValue1, startValue2, stopValue1, stopValue2));

        }
    }
}
