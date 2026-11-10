using tyuiu.cources.programming.interfaces.Sprint4;
namespace Tyuiu.PlekhanovaKA.Sprint4.Task3.V29.Lib
{
    public class DataService : ISprint4Task3V29
    {
        public int Calculate(int[,] array)
        {
            int res = 1;
            for (int i = 0; i < array.GetLength(0); i++)
            {
                res*=array[i,0];
            }
            return res;
        }
    }
}
