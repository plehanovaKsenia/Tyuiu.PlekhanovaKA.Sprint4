using Tyuiu.PlekhanovaKA.Sprint4.Task4.V28.Lib;
namespace Tyuiu.PlekhanovaKA.Sprint4.Task4.V28.Test
{
    [TestClass]
    public sealed class DataServiceTest
    {
        [TestMethod]
        public void ValidCalculate()
        {
            DataService ds = new DataService();
            int[,] matrix = new[,] { { 1, 2, 3 }, { 4, 5, 6 }, { 7, 8, 9 } };
            int[,] wait = new[,] { { 1, 1, 3 }, { 1, 5, 1 }, { 7, 1, 9 } };
            int[,] res = ds.Calculate(matrix);
            CollectionAssert.AreEqual(wait, res);
        }
    }
}
