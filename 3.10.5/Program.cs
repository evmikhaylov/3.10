using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _3._10._5
{
	internal class Program
	{
		static void Main(string[] args)
		{
			Random rnd = new Random();
            Console.WriteLine("Игра \"Угадай число\" \nВведите максимальное число диапазона");
			int range = Int32.Parse(Console.ReadLine());
			int secret = rnd.Next(0, ++range);
			while (true)
			{
                Console.WriteLine("Введите предполагаемое число ");
				string value = Console.ReadLine();
				if (value == System.String.Empty)
				{
                    Console.WriteLine($"Загаданное число {secret}");
					break;
                }
				int number = Int32.Parse(value);
				if (number > secret)
				{
					Console.WriteLine("Введенное число больше загаданного");
				}
				else if (number < secret)
				{
					Console.WriteLine("Введенное число меньше загаданного ");
				}
				else if (value == System.String.Empty)
				{
                    Console.WriteLine($"Загаданное число {secret}");
					Console.ReadKey();
					break;
                }
				else
				{
					Console.WriteLine("Вы угадали число");
					break;
				}
                Console.WriteLine("Что бы прекратить игру нажмите Enter");

            }
			Console.ReadKey();
        }
	}
}
