using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp19
{
	class Program
	{
		static int[,] Mass()
		{
			Console.Write("Введите количество строк: ");
			int n = int.Parse(Console.ReadLine());
			Console.Write("Введите количество столбцов: ");
			int m = int.Parse(Console.ReadLine());
			int[,] mass = new int[n, m];
			Random rand = new Random();

			for (int i = 0; i < mass.GetLength(0); i++)
			{
				for (int j = 0; j < mass.GetLength(1); j++)
				{
					mass[i, j] = rand.Next(0, 10);
				}
			}
			return mass;
		}

		static void Print(int[,] mass)
		{
			for (int i = 0; i < mass.GetLength(0); i++)
			{
				for (int j = 0; j < mass.GetLength(1); j++)
				{
					Console.Write(mass[i, j] + " ");
				}

				Console.WriteLine();
			}
		}

		static float Srednee(int[,] mass)
		{
			int s = 0;
			int n = mass.GetLength(0);
			for (int i = 0; i < n; i++)
			{
				s += mass[i, n - i - 1];
			}
			Console.WriteLine((float)s/n);
			return (float)s / n;
		}

		static void Main(string[] args)
		{
			try
			{
				int[,] Massive = Mass();
				Console.WriteLine("Исходный массив: ");
				Print(Massive);
				Console.WriteLine("Среднее арифметическое: ");
				Srednee(Massive);
			}
			catch
			{
				Console.WriteLine("Неверные данные");
			}
		
			Console.ReadKey();
		}
	}
}
