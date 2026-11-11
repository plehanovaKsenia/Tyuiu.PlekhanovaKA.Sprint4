using Tyuiu.PlekhanovaKA.Sprint4.Task6.V28.Lib;
namespace Tyuiu.PlekhanovaKA.Sprint4.Task6.V28.Test
{
    [TestClass]
    public sealed class DataServiceTest
    {
        [TestMethod]
        public void ValidCalculate()
        {
            DataService ds = new DataService();
            string[] array = { "Лужа", "Болото", "Камень", "Река", "Июнь", "Май" };
            string[] wait = { "Лужа", "Река", "Июнь" };
            string[] res = ds.Calculate(array);
            CollectionAssert.AreEqual(wait, res);
        }
    }
}
