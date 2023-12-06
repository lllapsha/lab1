﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace lab1._1 //17 вариант
{
    internal class Class1
    {
        static void Main(string[] args)
        {
            double[] array = new double[10];
            Random random = new Random();
            for (int i = 0; i < array.Length; i++)
            {
                array[i] = random.Next(-100, 100) + random.NextDouble() * 10;
            }
            double sum = 0;
            for (int i = array.Length - 1; array[i] > 0; i--)
            {
                sum += (int)array[i];
            }
            int C = random.Next(-100,100);
            int count = 0;
            foreach (double i in array)
            {
                if (i < C)
                {
                    count++;
                }
            }
            Console.WriteLine("массив:");
            printarr(array);
            Console.WriteLine("сумма целых частей элементов массива, расположенных после последнего отрицательного элемента:");
            Console.WriteLine(sum);
            Console.WriteLine("С = " + C);
            Console.WriteLine("количество элементов массива, меньших С:");
            Console.WriteLine(count);
            Array.Sort(array);
            Array.Reverse(array);
            Console.WriteLine("сначала располагалются все элементы, отличающиеся от максимального не более чем на 20%, а потом — все остальные:");
            printarr(array);


            int[,] matrix = new int[10, 10];

            for (int i = 0; i < 10; i++)
            {
                for (int j = 0; j < 10; j++)
                {
                    matrix[i, j] = random.Next(-3, 2);
                }
            }

            int str = 0;
            for (int i = 0; i < 10; i++)
            {
                for (int j = 0; j < 10; j++)
                {
                    if (matrix[i, j] == 0)
                    {
                        str++;
                        break;
                    }
                }
            }
            Console.WriteLine("матрица:");
            printmat(matrix);
            Console.WriteLine("количество строк, содержащих хотя бы один нулевой элемент:");
            Console.WriteLine(str);

            int len = 1;
            int column = 0;
            for (int i = 0; i < 10; i++) //столбец
            {
                int schet = 1;
                for (int j = 1; j < 10; j++) //строка
                {
                    if (matrix[j, i] == matrix[j - 1, i])
                        schet++;
                    else
                    {
                        if (schet >= len)
                        {
                            len = schet;
                            column = i;
                        }
                        schet = 0;
                    }
                }
            }

            Console.WriteLine("номер столбца, в котором находится самая длинная серия одинаковых элементов:");
            Console.WriteLine(column);

        }
        public static void printarr(double[] arr)
        {
            Console.WriteLine(string.Join(", ", arr));
        }

        public static void printmat(int[,] mat)
        {
            for (int i = 0; i < mat.GetLength(0); i++, Console.WriteLine())
                for (int j = 0; j < mat.GetLength(1); j++)
                    Console.Write("{0,5}", mat[i, j]);
        }
    }
}
