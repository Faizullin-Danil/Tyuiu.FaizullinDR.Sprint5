using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Tyuiu.FaizullinDR.Sprint5.Task7.V1.Lib;
using System.IO;

namespace Tyuiu.FaizullinDR.Sprint5.Task7.V1
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
            Console.WriteLine("* Задание #6                                                                           *");
            Console.WriteLine("* Вариант #8                                                                           *");
            Console.WriteLine("* Выполнил: Файзуллин Данил Рамилевич | ИИПБ-23-3                                      *");
            Console.WriteLine("****************************************************************************************");
            Console.WriteLine("* УСЛОВИЕ:                                                                             *");
            Console.WriteLine("* Дан файл С: DataSprint5 InPutDataFileTask6V8.txt (файл взять из архива согласно      *");
            Console.WriteLine("* вашему варианту. Создать папку в ручную С: DataSprint5  и скопировать в неё файл)    *");
            Console.WriteLine("* в котором есть набор символьных данных. Найти количество слов длиной два символа     *");
            Console.WriteLine("* в заданной строке.                                                                   *");
            Console.WriteLine("****************************************************************************************");
            Console.WriteLine("* ИСХОДНЫЕ ДАННЫЕ:                                                                     *");
            Console.WriteLine("****************************************************************************************");

            string path = @"C:\DataSprint5\InPutDataFileTask7V1.txt";

            Console.WriteLine("Данные находятся в файле: " + path);

            Console.WriteLine("****************************************************************************************");
            Console.WriteLine("* РЕЗУЛЬТАТ:                                                                           *");
            Console.WriteLine("****************************************************************************************");

            string res = ds.LoadDataAndSave(path);

            Console.WriteLine("Файл: " + res);
            Console.WriteLine("Создан!");


            Console.ReadLine();
        }
    }
}
