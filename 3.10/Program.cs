using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _3._10
{
	internal class Program
	{
		static void Main(string[] args)
		{
            Console.WriteLine("Введите число:");
			int number = Int32.Parse(Console.ReadLine());
			string even = "Вы ввели чётное число";
			string odd = "Вы ввели нечётное число";
			if (number%2==0)
			{
				Console.WriteLine(even);
			}
			else
			{
				Console.WriteLine(odd);
			}
			//Console.WriteLine((number % 2== 0) ? even : odd);
			Console.ReadKey();
        }
	}
}
