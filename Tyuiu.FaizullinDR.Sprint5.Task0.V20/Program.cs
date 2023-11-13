using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using Tyuiu.FaizullinDR.Sprint5.Task0.V20.Lib;

namespace Tyuiu.FaizullinDR.Sprint5.Task0.V20
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
            Console.WriteLine("* Тема: Обработка структурных типов                                                    *");
            Console.WriteLine("* Задание #0                                                                           *");
            Console.WriteLine("* Вариант #20                                                                          *");
            Console.WriteLine("* Выполнил: Файзуллин Данил Рамилевич | ИИПБ-23-3                                      *");
            Console.WriteLine("****************************************************************************************");
            Console.WriteLine("* УСЛОВИЕ:                                                                             *");
            Console.WriteLine("* Дано выражение                                                                       *");
            Console.WriteLine("* F(x) = 2.12x^3 + 1.05x^2 + 4.1x * 2, вычислить его значение при x = 2,               *");
            Console.WriteLine("* результат сохранить в текстовый файл OutPutFileTask0.txt и вывести на консоль.       *");
            Console.WriteLine("* Округлить до трёх знаков после запятой.                                              *");
            Console.WriteLine("****************************************************************************************");
            Console.WriteLine("* ИСХОДНЫЕ ДАННЫЕ:                                                                     *");
            Console.WriteLine("****************************************************************************************");

            int x = 2;
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
