using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Tyuiu.FaizullinDR.Sprint5.Task2.V15.Lib;

namespace Tyuiu.FaizullinDR.Sprint5.Task2.V15
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
            Console.WriteLine("* Задание #2                                                                           *");
            Console.WriteLine("* Вариант #15                                                                          *");
            Console.WriteLine("* Выполнил: Файзуллин Данил Рамилевич | ИИПБ-23-3                                      *");
            Console.WriteLine("****************************************************************************************");
            Console.WriteLine("* УСЛОВИЕ:                                                                             *");
            Console.WriteLine("* Дан двумерный целочисленный массив 3 на 3 элементов, заполненный значениями          *");
            Console.WriteLine("* с клавиатуры. Заменить нечетные элементы массива на 0.                               *");
            Console.WriteLine("* Результат сохранить в файл OutPutFileTask2.csv и вывести на консоль.                 *");
            Console.WriteLine("* 6; 1; 7                                                                              *");
            Console.WriteLine("* 5; 8; 5                                                                              *");
            Console.WriteLine("* 6; 6; 4                                                                              *");
            Console.WriteLine("****************************************************************************************");
            Console.WriteLine("* ИСХОДНЫЕ ДАННЫЕ:                                                                     *");
            Console.WriteLine("****************************************************************************************");

            int[,] arr = new int[3, 3];
            for (int i = 0; i < arr.GetLength(0); i++)
            {
                for (int j = 0; j < arr.GetLength(1); j++)
                {
                    Console.Write($"Введите {i},{j} элемент матрицы:");
                    arr[i, j] = Convert.ToInt32(Console.ReadLine());
                    Console.WriteLine();
                }
            }

            Console.WriteLine("****************************************************************************************");
            Console.WriteLine("* РЕЗУЛЬТАТ:                                                                           *");
            Console.WriteLine("****************************************************************************************");

            string res = ds.SaveToFileTextData(arr);

            Console.WriteLine("Файл: " + res);
            Console.WriteLine("Создан!");

            
            Console.ReadLine();
        }
    }
}
