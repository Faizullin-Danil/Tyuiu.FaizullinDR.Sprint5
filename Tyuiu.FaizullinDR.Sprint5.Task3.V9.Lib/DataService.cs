using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;
using tyuiu.cources.programming.interfaces.Sprint5;

namespace Tyuiu.FaizullinDR.Sprint5.Task3.V9.Lib
{
    public class DataService : ISprint5Task3V9
    {
        public string SaveToFileTextData(int x)
        {
                string path = $@"{Directory.GetCurrentDirectory()}\OutPutFileTask3.bin";

                double y = ((double)Math.Pow(x, 3)) / ((double)Math.Pow(x, 2) - 1);
                y = Math.Round(y, 3);

                using (BinaryWriter writer = new BinaryWriter(File.Open(path, FileMode.OpenOrCreate), Encoding.UTF8))
                {
                    writer.Write(BitConverter.GetBytes(y));
                }
                return path;
        }
    }
}
