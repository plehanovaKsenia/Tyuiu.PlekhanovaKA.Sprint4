using Tyuiu.PlekhanovaKA.Sprint4.Task0.V24.Lib;
namespace Tyuiu.PlekhanovaKA.Sprint4.Task0.V24.Test
{
    [TestClass]
    public sealed class DataServiceTest
    {
        [TestMethod]
        public void ValidGetMultEvenArrEl()
        {
            DataService ds = new DataService();
            int[] array = new int[10] { 1, 2, 3, 4, 5, 6, 7, 8, 9, 1 };
            int wait = 384;
            int res = ds.GetMultEvenArrEl(array);
            Assert.AreEqual(wait, res);
        }
    }
}
