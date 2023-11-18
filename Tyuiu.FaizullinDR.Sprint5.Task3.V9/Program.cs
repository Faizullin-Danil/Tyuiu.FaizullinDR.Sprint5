using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Tyuiu.FaizullinDR.Sprint5.Task3.V9.Lib;

namespace Tyuiu.FaizullinDR.Sprint5.Task3.V9
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
            Console.WriteLine("* Задание #3                                                                           *");
            Console.WriteLine("* Вариант #9                                                                           *");
            Console.WriteLine("* Выполнил: Файзуллин Данил Рамилевич | ИИПБ-23-3                                      *");
            Console.WriteLine("****************************************************************************************");
            Console.WriteLine("* УСЛОВИЕ:                                                                             *");
            Console.WriteLine("* Дано выражение вычислить его значение при x = 3,                                     *");
            Console.WriteLine("* результат сохранить в бинарный файл OutPutFileTask3.bin и вывести на консоль.        *");
            Console.WriteLine("*  Округлить до трёх знаков после запятой.                                             *");
            Console.WriteLine("*      x^3                                                                             *");
            Console.WriteLine("* y = -----                                                                            *");
            Console.WriteLine("*     x^2-1                                                                            *");
            Console.WriteLine("****************************************************************************************");
            Console.WriteLine("* ИСХОДНЫЕ ДАННЫЕ:                                                                     *");
            Console.WriteLine("****************************************************************************************");

            int x = 3;
            Console.WriteLine("x = " + x);

            Console.WriteLine("****************************************************************************************");
            Console.WriteLine("* РЕЗУЛЬТАТ:                                                                           *");
            Console.WriteLine("****************************************************************************************");

            string res = ds.SaveToFileTextData(x);

            Console.WriteLine("Файл: " + res);
            Console.WriteLine("Создан!");


            Console.ReadLine();
        }
    }
}
