using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

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

            Console.WriteLine("Введите своё имя");

            var name = Console.ReadLine();

            Console.WriteLine("Ваше имя по буквам: ");

            for (var ch=name.Length-1;ch>-1;ch--)
            {
                Console.Write(name[ch] + " ");
            }

            Console.WriteLine("Последняя буква вашего имени: {0}", name[name.Length - 1]);

            Console.ReadKey();
        }
    }
}
