using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Tyuiu.FaizullinDR.Sprint5.Task5.V26.Lib;
using System.IO;

namespace Tyuiu.FaizullinDR.Sprint5.Task5.V26
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
            Console.WriteLine("* Задание #5                                                                           *");
            Console.WriteLine("* Вариант #26                                                                          *");
            Console.WriteLine("* Выполнил: Файзуллин Данил Рамилевич | ИИПБ-23-3                                      *");
            Console.WriteLine("****************************************************************************************");
            Console.WriteLine("* УСЛОВИЕ:                                                                             *");
            Console.WriteLine("* Дан файл С:DataSprint5InPutDataFileTask5V26.txt (файл взять из архива                *");
            Console.WriteLine("* согласно вашему варианту. Создать папку в ручную С: DataSprint5 и скопировать в      *");
            Console.WriteLine("* неё файл) в котором есть набор значений. Найти разницу между суммой всех             *");
            Console.WriteLine("* положительных и отрицательных вещественных чисел в файле.                            *");
            Console.WriteLine("* Результат округлить до 3 знаков после запятой. Полученный результат вывести          *");
            Console.WriteLine("* на консоль. У вещественных значений округлить до трёх знаков после запятой.          *");
            Console.WriteLine("****************************************************************************************");
            Console.WriteLine("* ИСХОДНЫЕ ДАННЫЕ:                                                                     *");
            Console.WriteLine("****************************************************************************************");

            string path = @"C:\DataSprint5\InPutDataFileTask5V26.txt";

            Console.WriteLine("Данные находятся в файле" + path);

            Console.WriteLine("****************************************************************************************");
            Console.WriteLine("* РЕЗУЛЬТАТ:                                                                           *");
            Console.WriteLine("****************************************************************************************");

            double res = ds.LoadFromDataFile(path);

            Console.WriteLine(res);


            Console.ReadLine();
        }
    }
}
