using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;
using tyuiu.cources.programming.interfaces.Sprint5;

namespace Tyuiu.FaizullinDR.Sprint5.Task6.V8.Lib
{
    public class DataService : ISprint5Task6V8
    {
        public int LoadFromDataFile(string path)
        {
            string r = File.ReadAllText(path) ;
            string[] str = r.Split(' ');
            int res = 0;
            for (int i = 0; i < str.Length; i++)
            {
                if (str[i].Length == 2)
                    res++;
            }
            return res;
        }
    }
}
