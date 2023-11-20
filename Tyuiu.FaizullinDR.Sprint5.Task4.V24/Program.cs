using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Tyuiu.FaizullinDR.Sprint5.Task4.V24.Lib;
using System.IO;

namespace Tyuiu.FaizullinDR.Sprint5.Task4.V24
{
    class Program
    {
        static void Main(string[] args)
        {
            DataService ds = new DataService();


            Console.Title = "Спринт #5 | Выполнил: Файзуллин Д. Р. | ИИПБ-23-3";
            //Длина строки 75 символов
            Console.WriteLine("****************************************************************************************");
            Console.WriteLine("* Спринт #5                                                                            *");
            Console.WriteLine("* Тема: Обработка файлов                                                               *");
            Console.WriteLine("* Задание #4                                                                           *");
            Console.WriteLine("* Вариант #24                                                                          *");
            Console.WriteLine("* Выполнил: Файзуллин Данил Рамилевич | ИИПБ-23-3                                      *");
            Console.WriteLine("****************************************************************************************");
            Console.WriteLine("* УСЛОВИЕ:                                                                             *");
            Console.WriteLine("* Дан файл С:DataSprint5InPutDataFileTask4V0.txt (файл взять из архива                 *");
            Console.WriteLine("* согласно вашему варианту. Создать папку в ручную С:DataSprint5 и скопировать         *");
            Console.WriteLine("* в неё файл) в котором есть вещественное значение.                                    *");
            Console.WriteLine("* Прочитать значение из файла и подставить вместо Х в формуле y = (x^-2 + 2)sin(x)     *");
            Console.WriteLine("* Вычислить значение по формуле (Полученное значение округлить                         *");
            Console.WriteLine("* до трёх знаков после запятой) и вернуть полученный результат на консоль.             *");
            Console.WriteLine("****************************************************************************************");
            Console.WriteLine("* ИСХОДНЫЕ ДАННЫЕ:                                                                     *");
            Console.WriteLine("****************************************************************************************");

            string path = @"C:\DataSprint5\InPutDataFileTask4V24.txt";

            Console.WriteLine("****************************************************************************************");
            Console.WriteLine("* РЕЗУЛЬТАТ:                                                                           *");
            Console.WriteLine("****************************************************************************************");

            double res = ds.LoadFromDataFile(path);

            Console.WriteLine(res);


            Console.ReadLine();
        }
    }
}
