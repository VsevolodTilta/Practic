using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp4
{
	class Program
	{
		static double f(double x)
		{
			try
			{
				if (x == -1) throw new Exception();
				else
					return Math.Sqrt(5 - Math.Pow(x, 3));
			}
			catch
			{
				throw;
			}
		}
		static void Main(string[] args)
		{
			try
			{
				Console.Write("Введите а: ");
				double a = double.Parse(Console.ReadLine());
				Console.Write("Введите в: ");
				double b = double.Parse(Console.ReadLine());
				Console.Write("Введите h: ");
				double h = double.Parse(Console.ReadLine());
				for (double i = 0; i <= b; i += h)
					try
					{
						Console.WriteLine("y({0})={1:f4}", i, f(i));
					}
					catch
					{
						Console.WriteLine("y({0})=error", i);
					}
			}
			catch (FormatException)
			{
				Console.WriteLine("Неверный формат ввода данных");
			}
			catch
			{
				Console.WriteLine("Неизвестная ошибка");
			}
			Console.ReadKey();

		}
	}
}
