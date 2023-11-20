using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;
using tyuiu.cources.programming.interfaces.Sprint5;

namespace Tyuiu.FaizullinDR.Sprint5.Task4.V24.Lib
{
    public class DataService : ISprint5Task4V24
    {
        public double LoadFromDataFile(string path)
        {
            string str = File.ReadAllText(path);
            double x = Convert.ToDouble(str);
            double res = (Math.Pow(x, -2) + 2) * Math.Sin(x);
            return Math.Round(res,3);
        }
    }
}
