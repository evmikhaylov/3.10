using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _3._10._2
{
	internal class Program
	{
		static void Main(string[] args)
		{
            Console.WriteLine("Ввидите количество карт у Вас на руках");
			int count= Int32.Parse(Console.ReadLine());
			int sum = 0;

			for (int i = 0; i < count; i++)
			{
                Console.WriteLine("Введите номинал карты");
				string cost=Console.ReadLine();
				switch (cost)
				{
					case "2":
						sum = sum + 2;
                        Console.WriteLine("Ваша карта 2");
						break;
					case "3":
						sum = sum + 3;
						Console.WriteLine("Ваша карта 3");
						break;
					case "4":
						sum = sum + 4;
						Console.WriteLine("Ваша карта 4");
						break;
					case "5":
						sum = sum + 5;
						Console.WriteLine("Ваша карта 5");
						break;
					case "6":
						sum = sum + 6;
						Console.WriteLine("Ваша карта 6");
						break;
					case "7":
						sum = sum + 7;
						Console.WriteLine("Ваша карта 7");
						break;
					case "8":
						sum = sum + 8;
						Console.WriteLine("Ваша карта 8");
						break;
					case "9":
						sum = sum + 9;
						Console.WriteLine("Ваша карта 9");
						break;
					case "10":
						sum = sum + 10;
						Console.WriteLine("Ваша карта 10");
						break;
					case "J":
						sum = sum + 10;
						Console.WriteLine("Ваша карта Валет");
						break;
					case "Q":
						sum = sum + 10;
						Console.WriteLine("Ваша карта Дама");
						break;
					case "K":
						sum = sum + 10;
						Console.WriteLine("Ваша карта Король");
						break;
					case "T":
						sum = sum + 10;
						Console.WriteLine("Ваша карта Туз");
						break;
					default: Console.WriteLine("Такой карты нет");
						--i;
						break;

				}
			}
			Console.WriteLine($"Вы набрали {sum}");
			Console.ReadKey();
		}
	}
}
