using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO; // для рвботы с классом File 

using tyuiu.cources.programming.interfaces.Sprint5;

namespace Tyuiu.FaizullinDR.Sprint5.Task0.V20.Lib
{
    public class DataService : ISprint5Task0V20
    {
        public string SaveToFileTextData(int x)
        {
            string path = $@"{Directory.GetCurrentDirectory()}\OutPutFileTask0.txt";
            double z = 2.12 * Math.Pow((double)x, 3) + 1.05 * Math.Pow((double)x,2) + 4.1 * (double)x * 2; // поменять int на double
            z = Math.Round(z, 3);
            File.WriteAllText(path, Convert.ToString(z));
            return path;
        }
    }
}
