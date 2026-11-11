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
            int n = 2;
            int m = 2;
            string value = "1234";
            int wait = 6;
            int res = ds.Calculate(n,m, value);
            Assert.AreEqual(wait, res);
        }
    }
}
