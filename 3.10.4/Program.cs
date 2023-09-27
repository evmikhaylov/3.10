using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _3._10._4
{
	internal class Program
	{
		static void Main(string[] args)
		{
            Console.WriteLine("Введите длину последовательности чисел для поиска наименьшего значения");
            int length = Int32.Parse(Console.ReadLine());
			int minValue = int.MaxValue;
			for (int i = 0; i < length; i++)
			{
				Console.WriteLine($"Введите {i+1} число");
				int number=Int32.Parse(Console.ReadLine());
				if (minValue>number)
				{
					minValue=number;
				}
				
			}
			Console.WriteLine($"Минимальное значение = {minValue}");
			Console.ReadKey();
            
        }
	}
}
