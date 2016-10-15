using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Arrays
{
    class Program
    {
        static void Main()
        {
            //Одномерные массивы.Способы объявления.

            //int[] array = { 0, 1, 2, 3, 4 };
            //
            //array = new int[5];
            //
            //array = new int[5] { 0, 1, 2, 3, 4 };
            //
            //array = new int[] { 0, 1, 2, 3, 4 };
            //
            ////Вывод на экран значений элементов массива
            //
            //for (int i = 0; i < array.Length; i++)
            //{
            //    Console.WriteLine(array[i]);
            //}
            //
            ////Delay
            //
            //Console.ReadKey();



            ////Двумерный массивы.Способы объявления.
            //
            //Random random = new Random();
            //
            //int[,] array = new int[3, 3];
            //
            ////Заполнение массива случайными значениями
            //
            //for (int i = 0; i < 3; i++)
            //{
            //    for (int j = 0; j < 3; j++)
            //    {
            //        array[i, j] = random.Next(0, 25);
            //    }
            //}
            //
            ////Вывод на экран значений двумерного массива
            //
            //for (int i = 0; i < 3; i++)
            //{
            //    for (int j = 0; j < 3; j++)
            //    {
            //        Console.Write("{0} ", array[i, j]);
            //    }
            //    Console.Write("\n");
            //}
            //
            ////Delay
            //
            //Console.ReadKey();



            ////Создание трехмерный массив
            //int[,,] threeDim =  {
            //                        { {1, 2}, {3, 4} },
            //                        { {5, 6}, {7, 8} }
            //                    };
            ////Получаем кол-во подмассивов в массиве - GetLength(0) - 2 подмассива
            //for (int i = 0; i < threeDim.GetLength(0); i++)
            //{
            //    //Получаем кол-во элементов в подмассиве -GetLength(1) - 4 элемента в каждом подмассиве.
            //    for (int j = 0; j < threeDim.GetLength(1); j++)
            //    {
            //        for (int k = 0; k < threeDim.GetLength(2); k++)
            //        {
            //            Console.Write(threeDim[i, j, k] + ", ");
            //        }
            //        Console.WriteLine();
            //    }
            //}
            //
            ////Выводим на консоль длинну массива
            //
            //Console.WriteLine(threeDim.Length);
            //
            ////Delay
            //Console.ReadKey();

            ////Создание зубчатого массива
            //
            //int[][] jagged = new int[3][];
            //
            //jagged[0] = new int[] { 1, 2 };
            //jagged[1] = new int[] { 1, 2, 3 };
            //jagged[2] = new int[] { 1, 2, 3, 4 };
            //
            ////Во внешнем цикле выполняется проход по всем вложенным массивам.
            //
            //for (int i = 0; i < jagged.Length; i++)
            //{
            //    //Во внутреннем цикле выполняется обращение к каждому элементу вложенного массива
            //    for (int j = 0; j < jagged[i].Length; j++)
            //    {
            //        Console.Write("{0} ", jagged[i][j]);
            //    }
            //    Console.Write("\n");
            //}
            //
            ////Delay
            //Console.ReadKey();

            ////Абстрактный класс Array. Все Массивы являются производными от класса Array.
            //
            //int[] vector = { 1, 2, 3};
            //
            //Array array = vector as Array;
            //
            //for (int i = 0; i < array.Length; i++)
            //{
            //    Console.WriteLine(vector[i]);
            //}
            //
            ////Delay
            //Console.ReadKey();

            //Неявно типизированные массивы

            // Массив Int32.
            var array1 = new[] { 1, 2, 3, 4};
            Console.WriteLine(array1.GetType());

            //Массив Doubles.
            var array2 = new[] { 3.1415, 1, 6 };
            Console.WriteLine(array2.GetType());

            //Не компилируются несовместимые типы.
            //var array3 = new[]{ 1, "string"};

            //Delay
            Console.ReadKey();
        }
    }
}
