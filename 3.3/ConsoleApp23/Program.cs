using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp23
{
	class Program
	{
		static void f(double x, out double y)
		{
			if (Math.Abs(x) <= 0.1)
				y = Math.Pow(x, 3) - 0.1;
			else if (Math.Abs(x) >= 0.1)
				y = 0.2 * x - 0.1;
			else
				y = Math.Pow(x, 3) + 0.1;
		}

		static double f(double x)
		{
			double y;
			if (Math.Abs(x) <= 0.1)
				y = Math.Pow(x, 3) - 0.1;
			else if (Math.Abs(x) >= 0.1)
				y = 0.2 * x - 0.1;
			else
				y = Math.Pow(x, 3) + 0.1;
			return y;
		}
		static void Main(string[] args)
		{
			Console.Write("Введите первое число: ");
			double a = double.Parse(Console.ReadLine());

			Console.Write("Введите второе число: ");
			double b = double.Parse(Console.ReadLine());

			Console.Write("Введите третье число: ");
			double h = double.Parse(Console.ReadLine());

			for (double i = a; i <= b; i += h)
			{
				Console.WriteLine("f({0:f2})={1:f4}", i, f(i));
			}

			for (double i = a; i <= b; i += h)
			{
				double y;
				f(i, out y);

				Console.WriteLine("f({0:f2})={1:f4}", i, y);
			}
			Console.ReadKey();
		}
	}
}
