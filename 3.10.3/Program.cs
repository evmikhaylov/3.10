using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _3._10._3
{
	internal class Program
	{
		static void Main(string[] args)

		{
			Console.WriteLine("Введите натуральное число на проверку");
			uint number = UInt32.Parse(Console.ReadLine());
			uint i = 1;
			bool complex = true;
			if (number==1) 
			{
				Console.WriteLine("1 является не простым и не составным числом");
			}
            while (number-i>=1)
			{
				
				i++;
				if (complex= number%i==0 & number!=2)
				{
					
					Console.WriteLine("Число составное");
					break;
                }
				else
				{
                    Console.WriteLine("Число простое");
					break;
                }

			}
			Console.ReadKey();
        }
	}
}
