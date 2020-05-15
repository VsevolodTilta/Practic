using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp17
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

		static void Change(int[,] mass)
		{
			Console.Write("Введите число: ");
			int numb = int.Parse(Console.ReadLine());
			for (int i = 0; i < mass.GetLength(0); i++)
			{
				for (int j = 0; j < mass.GetLength(1); j++)
				{
					if (mass[i, j] > numb)
						mass[i, j] = (int)mass[i, j] * 2; ;
				}
			}
		}


		static void Main(string[] args)
		{
			int[,] Massive = Mass();
			Console.WriteLine("Исходный массив: ");
			Print(Massive);
			Change(Massive);
			Console.WriteLine("Измененный массив: ");
			Print(Massive);

			Console.ReadKey();
		}
	}
}
