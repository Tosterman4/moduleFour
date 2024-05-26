using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Policy;
using System.Text;
using System.Threading.Tasks;
using System.Xml.Linq;

namespace moduleFour
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //Задание по циклам
            /*Console.WriteLine("Напишите свой любимый цвет на английском с маленькой буквы");
            int t = 0;
            do
            {
                var text = Console.ReadLine();
                if (text == "stop")
                {
                    Console.WriteLine("is stoped");
                    break;
                }
                switch (text)
                {
                    case "red":
                        Console.BackgroundColor = ConsoleColor.Red;
                        Console.ForegroundColor = ConsoleColor.Black;

                        Console.WriteLine("Your color is red!");
                        break;

                    case "green":
                        Console.BackgroundColor = ConsoleColor.Green;
                        Console.ForegroundColor = ConsoleColor.Black;

                        Console.WriteLine("Your color is green!");
                        break;

                    case "cyan":
                        Console.BackgroundColor = ConsoleColor.Cyan;
                        Console.ForegroundColor = ConsoleColor.Black;

                        Console.WriteLine("Your color is cyan!");
                        break;

                    default:
                        Console.BackgroundColor = ConsoleColor.Yellow;
                        Console.ForegroundColor = ConsoleColor.Red;

                        Console.WriteLine("Your color is yellow!");
                        break;
                }
                t++;
            }
            while (t < 3);
            */

            //Задание по массивам
            /*Console.WriteLine("Введите своё имя");

            var name = Console.ReadLine();

            Console.WriteLine("Ваше имя по буквам: ");

            for (var ch=name.Length-1;ch>-1;ch--)
            {
                Console.Write(name[ch] + " ");
            }

            Console.WriteLine("Последняя буква вашего имени: {0}", name[name.Length - 1]);*/

            //Вывод по стоолбцам и стррокам
            /*int[,] array = { { 1, 2, 3 }, { 5, 6, 7 }, { 8, 9, 10 }, { 11, 12, 13 } };

            for (int i = 0; i < array.GetUpperBound(1) + 1; i++)
            {
                for (int k = 0; k < array.GetUpperBound(0) + 1; k++)
                    Console.Write(array[k, i] + " ");

                Console.WriteLine();
            }*/

            //Сложение элементов массива
            /*var arr = new int[] { 5, 6, 9, 1, 2, 3, 4 };
            int temp=0;
            for (int i = 0; i < arr.Length; i++)
            {
                temp = arr[i] + temp;
            }
            Console.Write(temp);*/

            //Перебор зубчатого массива
            /*int[][] array = new int[3][];
            array[0] = new int[2] { 1, 2 };
            array[1] = new int[3] { 1, 2, 3 };
            array[2] = new int[5] { 1, 2, 3, 4, 5 };

            foreach (var num in array)
            {
                foreach (var item in num)
                {
                    Console.Write(item + " ");
                }
            }*/

            //Нахождение положительных чисел
            int[,] arr = { { -5, 6, 9, 1, 2, -3 }, { -8, 8, 1, 1, 2, -3 } };
            int temp = 0;

            for (int i = 0; i < arr.GetUpperBound(0) + 1; i++)
            {
                for (int j = 0; j < arr.GetUpperBound(1) + 1; j++)
                {
                    for (int k = j + 1; k < arr.GetUpperBound(1)+1; k++)
                    {
                        if (arr[i, j] > arr[i, k])
                        {
                            temp = arr[i, k];
                            arr[i,k] = arr[i,j];
                            arr[i,j] = temp;
                        }
                    }
                    Console.Write(arr[i, j] + " ");
                }
                Console.WriteLine();
            }

            /*for (int i = 0; i < arr.GetUpperBound(0)+1; i++)
            {
                for (int j = 0; j < arr.GetUpperBound(1) + 1; j++)
                {
                    if (arr[i,j] > 0)
                    {
                        num++;
                    }
                }
            }
            Console.Write(num);*/

            Console.ReadKey();
        }
    }
}
