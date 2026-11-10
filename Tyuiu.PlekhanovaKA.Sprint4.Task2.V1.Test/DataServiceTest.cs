using Tyuiu.PlekhanovaKA.Sprint4.Task2.V1.Lib;
namespace Tyuiu.PlekhanovaKA.Sprint4.Task2.V1.Test
{
    [TestClass]
    public sealed class DataServiceTest
    {
        [TestMethod]
        public void ValidCalculate()
        {
            DataService ds = new DataService();
            int[] array = {1, 2, 3, 4 };
            int wait = 8;
            int res = ds.Calculate(array);
            Assert.AreEqual(wait, res);
        }
    }
}
