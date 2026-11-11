using Tyuiu.PlekhanovaKA.Sprint4.Task5.V3.Lib;
namespace Tyuiu.PlekhanovaKA.Sprint4.Task5.V3.Test
{
    [TestClass]
    public sealed class DataServiceTest
    {
        [TestMethod]
        public void ValidCalculate()
        {
            DataService ds = new DataService();
            int[,] matrix = { { 1, 2, 3 }, { -1, 2, -3 }, { 0, -7, 6 } };
            int [,] wait = { { 1, 2, 3 }, { 0, 2, 0 }, { 0, 0, 6 } };
            int[,] res = ds.Calculate(matrix);
            CollectionAssert.AreEqual(wait, res);
        }
    }
}
