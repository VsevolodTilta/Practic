using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Cryptography.X509Certificates;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp18
{
	class Program
	{

		static double fx(double x)
		{
			return Math.Cos(2 * x) + Math.Sin(x - 3);
		}
		static void Main(string[] args)
		{
			try {
				Console.Write("Введите а: ");
				double a = Convert.ToDouble(Console.ReadLine());
				Console.Write("Введите b: ");
				double b = Convert.ToDouble(Console.ReadLine());
				Console.WriteLine(fx(a) < fx(b) ? "Наибольшее число a" : "Наибольшее число b");
				Console.ReadKey();
			}
			catch
			{
				Console.WriteLine("Неверные данные");
				Console.ReadKey();
			}
		}

	}
} 
