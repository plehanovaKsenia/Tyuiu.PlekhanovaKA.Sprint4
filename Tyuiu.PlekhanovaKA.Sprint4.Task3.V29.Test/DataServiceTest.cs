using Tyuiu.PlekhanovaKA.Sprint4.Task3.V29.Lib;
namespace Tyuiu.PlekhanovaKA.Sprint4.Task3.V29.Test
{
    [TestClass]
    public sealed class DataServiceTest
    {
        [TestMethod]
        public void ValidCalculate()
        {
            DataService ds = new DataService();
            int[,] array = { { 1, 2, 3, }, { 2, 3, 4 }, { 4, 5, 6 } };
            int wait = 8;
            int res = ds.Calculate(array);
            Assert.AreEqual(wait, res);
        }
    }
}
