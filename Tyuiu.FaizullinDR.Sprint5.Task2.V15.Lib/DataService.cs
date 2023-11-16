using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;
using tyuiu.cources.programming.interfaces.Sprint5;

namespace Tyuiu.FaizullinDR.Sprint5.Task2.V15.Lib
{
    public class DataService : ISprint5Task2V15
    {
        public string SaveToFileTextData(int[,] matrix)
        {
            string path = $@"{Directory.GetCurrentDirectory()}\OutPutFileTask2.txt";

            FileInfo fileInfo = new FileInfo(path);
            bool fileExist = fileInfo.Exists;

            if (fileExist)
                File.Delete(path);

            string x;

            for (int i = 0; i < matrix.GetLength(0); i++)
            {
                for (int j = 0; j < matrix.GetLength(1); j++)
                {
                    if (matrix[i, j] % 2 != 0)
                        matrix[i, j] = 0;
                    x = Convert.ToString(matrix[i, j]);

                    if (j+1 != matrix.GetLength(1))
                    {
                        File.AppendAllText(path, x+" ");  
                    }
                    else
                    {
                        File.AppendAllText(path, x + Environment.NewLine);
                    }
                }
            }
            return path;
        }
    }
}
