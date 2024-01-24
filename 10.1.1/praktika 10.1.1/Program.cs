using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace praktika_10._1._1
{
    internal class Program
    {
        static void Main (string[] args)
        {
            //18
            //Console.WriteLine("Введите число M");//столбец
            //int m = Convert.ToInt32(Console.ReadLine());

            //Console.WriteLine("Введите чисо n");//строка
            //int n = Convert.ToInt32(Console.ReadLine());
            //Console.WriteLine();

            //int[,] mass = new int[m, n];

            //Random rnd = new Random();

            //for (int i = 0; i < mass.GetLength(0); i++)
            //{


            //    for (int j = 0; j < mass.GetLength(1); j++)
            //    {
            //        mass[i, j] = rnd.Next(0, 10);
            //        Console.Write(mass[i, j] + " ");
            //    }

            //    Console.WriteLine();

            //}

            //Console.WriteLine("Введите k");
            //int k = Convert.ToInt32(Console.ReadLine());

            //if (k > 0)
            //{
            //    Console.WriteLine("Введите k1");
            //    int k1 = Convert.ToInt32(Console.ReadLine());

            //    Console.WriteLine("Введите k2");
            //    int k2 = Convert.ToInt32(Console.ReadLine());

            //    int count = 0;
            //    int sum = 0;

            //    for (int i = 0; i < m; i++)
            //    {
            //        for (int j = 0; j < n; j++)
            //        {
            //            if (mass[i, j] > 0 && mass[i, j] % k == 0)
            //            {
            //                count++;
            //            }

            //            if (i > k1 - 1 && i <= k2 - 1)
            //            {
            //                sum += mass[i, j];
            //            }
            //        }
            //    }
            //    Console.WriteLine($"Количество положительных чисел кратных {k}: {count}");
            //    Console.WriteLine($"Сумма чисел в промежутке от {k1} до {k2}: {sum}");
            //}
            //else
            //    Console.WriteLine("k должно быть больше 0");




            //19
            //Console.WriteLine("Введите число M");//столбец
            //int m = Convert.ToInt32(Console.ReadLine());

            //Console.WriteLine("Введите чисо n");//строка
            //int n = Convert.ToInt32(Console.ReadLine());
            //Console.WriteLine();

            //int[,] mass = new int[m, n];

            //Random rnd = new Random();

            //int count = 0;
            //int proizv = 1;


            //Console.WriteLine("Введите a");
            //int a = Convert.ToInt32(Console.ReadLine());

            //Console.WriteLine("Введите б");
            //int b = Convert.ToInt32(Console.ReadLine());

            //Console.WriteLine("Введите k1");
            //int k1 = Convert.ToInt32(Console.ReadLine());

            //Console.WriteLine("Введите k2");
            //int k2 = Convert.ToInt32(Console.ReadLine());


            //for (int i = 0; i < mass.GetLength(0); i++)
            //{


            //    for (int j = 0; j < mass.GetLength(1); j++)
            //    {
            //        mass[i, j] = rnd.Next(0, 10);
            //        Console.Write(mass[i, j] + " ");
            //        if (mass[i, j] % a == 0 || mass[i, j] % b == 0)
            //        {
            //            count++;
            //        }

            //        if (i > k1 && i <= k2 && mass[i, j] < 0)
            //        {
            //            proizv *= mass[i, j];
            //        }
            //    }

            //    Console.WriteLine();

            //}
            //Console.WriteLine($"Количество элементов кратных a или b: {count}");
            //Console.WriteLine($"Произведение отрицательных элементов в промежутке от {k1} до {k2}: {proizv}");




            Console.ReadKey();
        }
    }
}
