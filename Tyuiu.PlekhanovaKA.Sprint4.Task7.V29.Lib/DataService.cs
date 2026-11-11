using tyuiu.cources.programming.interfaces.Sprint4;
namespace Tyuiu.PlekhanovaKA.Sprint4.Task7.V29.Lib
{
    public class DataService : ISprint4Task7V29
    {
        public int Calculate(int n, int m, string value)
        {
            int sum = 0;
            int[,] matrix = new int [n, m];
            for (int i=0;i<n;i++)
            {
                for(int j=0;j<m;j++)
                {
                    matrix[i, j] = int.Parse(value[i * m + j].ToString());
                    if (matrix[i,j]%2==0)
                    {
                        sum += matrix[i, j];
                    }
                }
            }
            return sum;
        }
    }
}
