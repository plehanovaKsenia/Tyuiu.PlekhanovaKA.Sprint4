using tyuiu.cources.programming.interfaces.Sprint4;
namespace Tyuiu.PlekhanovaKA.Sprint4.Task6.V28.Lib
{
    public class DataService : ISprint4Task6V28
    {
        public string[] Calculate(string[] array)
        {
            int len = array.Count(x => x.Length == 4);
            string[] s = new string [len];
            int i = 0;
            foreach(string item in array)
            {
                if(item.Length==4)
                {
                    s[i] = item;
                    i++;
                }
            }
            return s;
        }
    }
}
