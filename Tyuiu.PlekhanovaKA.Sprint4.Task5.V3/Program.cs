using System.Data;
using Tyuiu.PlekhanovaKA.Sprint4.Task5.V3.Lib;

namespace Tyuiu.PlekhanovaKA.Sprint4.Task5.V3
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Random rnd = new Random();
            DataService ds = new DataService();


            Console.Title = "Спринт #4 | Выполнила: Плеханова К. А. | СМАРТб-26-1";

            Console.WriteLine("***************************************************************************");
            Console.WriteLine("* Спринт #4                                                               *");
            Console.WriteLine("* Тема: Двумерные массивы (генератор случайных чисел)                     *");
            Console.WriteLine("* Задание#5                                                               *");
            Console.WriteLine("* Вариант#3                                                               *");
            Console.WriteLine("* Выполнила: Плеханова Ксения Анатольевна | СМАРТб-26-1                   *");
            Console.WriteLine("***************************************************************************");
            Console.WriteLine("* УСЛОВИЕ:                                                                *");
            Console.WriteLine("* Дан двумерный целочисленный массив 5 на 5 элементов, заполненный        *");
            Console.WriteLine("* случайными значениями в диапазоне от -5 до 4.                           *");
            Console.WriteLine("* Заменить отрицательные элементы на 0.                                   *");
            Console.WriteLine("***************************************************************************");
            Console.WriteLine("* ИСХОДНЫЕ ДАННЫЕ:                                                        *");
            Console.WriteLine("***************************************************************************");
            int rows, columns;
            Console.WriteLine("Введите количество строк массива");
            rows = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("Введите количество столбцов массива");
            columns = Convert.ToInt32(Console.ReadLine());
            int[,] matrix = new int[rows,columns];
            for (int i = 0; i < rows; i++)
            {
                for (int j = 0; j < columns; j++)
                {
                    matrix[i, j] = rnd.Next(1, 9);
                }
            }
            Console.WriteLine();
            Console.WriteLine("Массив:");
            Console.WriteLine(matrix);
            Console.WriteLine("***************************************************************************");
            Console.WriteLine("* РЕЗУЛЬТАТ:                                                              *");
            Console.WriteLine("***************************************************************************");
            int[,] res = ds.Calculate(matrix);
            Console.WriteLine(res);
        }
    }
}
