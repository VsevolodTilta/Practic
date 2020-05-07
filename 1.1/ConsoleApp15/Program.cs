using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp15
{
	class Program
	{
		static void Main(string[] args)
		{
			Console.Write("Первое число (модуль): ");
			double s = double.Parse(Console.ReadLine());
			Console.Write("Второе число (модуль): ");
			double n = double.Parse(Console.ReadLine());
			double p = Math.Sqrt(Math.Abs(s*n));
			Console.WriteLine("Среднее геометрическое двух модулей = " + p);
			Console.ReadKey();
		}
	}
}
