using Tyuiu.PlekhanovaKA.Sprint4.Task6.V28.Lib;
namespace Tyuiu.PlekhanovaKA.Sprint4.Task6.V28
{
    internal class Program
    {
        static void Main(string[] args)
        {
            DataService ds = new DataService();


            Console.Title = "Спринт #4 | Выполнила: Плеханова К. А. | СМАРТб-26-1";

            Console.WriteLine("***************************************************************************");
            Console.WriteLine("* Спринт #4                                                               *");
            Console.WriteLine("* Тема: Класс Array                                                       *");
            Console.WriteLine("* Задание#6                                                               *");
            Console.WriteLine("* Вариант#28                                                              *");
            Console.WriteLine("* Выполнила: Плеханова Ксения Анатольевна | СМАРТб-26-1                   *");
            Console.WriteLine("***************************************************************************");
            Console.WriteLine("* УСЛОВИЕ:                                                                *");
            Console.WriteLine("* Дан строковый массив данных, используя класс Array,                     *");
            Console.WriteLine("* выведите элементы массива, длина которых равна 4 символам.              *");
            Console.WriteLine("***************************************************************************");
            Console.WriteLine("* ИСХОДНЫЕ ДАННЫЕ:                                                        *");
            Console.WriteLine("***************************************************************************");
            string[] array = { "Река", "Озеро", "Болото", "Океан", "Лужа", "Море" };
            Console.WriteLine("Исходный массив");
            for(int i=0;i<array.Length;i++)
            {
                Console.WriteLine(array[i]);
            }
            
            Console.WriteLine("***************************************************************************");
            Console.WriteLine("* РЕЗУЛЬТАТ:                                                              *");
            Console.WriteLine("***************************************************************************");
            string[] res = ds.Calculate(array);
            Console.WriteLine(res);
        }
    }
}
