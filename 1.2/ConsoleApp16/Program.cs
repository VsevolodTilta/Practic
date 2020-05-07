using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp16
{
	class Program
	{
		static void Main(string[] args)
		{
			Console.Write("Введите число: ");
			int h = int.Parse(Console.ReadLine());
			if (h % 10 == 7)
				Console.WriteLine("Число оканчивается на 7");
			else
				Console.WriteLine("Число не оканчивается на 7");
			Console.ReadKey();
		}
	}
}
