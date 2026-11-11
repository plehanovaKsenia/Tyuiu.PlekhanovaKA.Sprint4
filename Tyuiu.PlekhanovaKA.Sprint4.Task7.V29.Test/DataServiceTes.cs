using Tyuiu.PlekhanovaKA.Sprint4.Task7.V29.Lib;
namespace Tyuiu.PlekhanovaKA.Sprint4.Task7.V29.Test
{
    [TestClass]
    public sealed class DataServiceTes
    {
        [TestMethod]
        public void ValidCalculate()
        {
            DataService ds = new DataService();
            int n = 4;
            int m = 3;
            string value = "983157642891";
            int wait = 28;
            int res = ds.Calculate(n,m, value);
            Assert.AreEqual(wait, res);
        }
    }
}
