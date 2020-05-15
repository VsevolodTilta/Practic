using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _6._3
{
	class Program
	{
		static int[,] Mass()
		{
			Console.Write("Введите кол-во строк: ");
			int n = int.Parse(Console.ReadLine());
			Console.Write("Введите кол-во столбцов: ");
			int m = int.Parse(Console.ReadLine());
			int[,] mass = new int[n,m];
			int[,] result = new int[n, m];
			Random rand = new Random();

			for (int i = 0; i < mass.GetLength(0); i++)
			{
				for (int j = 0; j < mass.GetLength(1); j++)
				{
					mass[i,j] = rand.Next(0, 10);
				}
			}
			return mass;
		}

		static void PrintMass(int[,] mass)
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

		static void PrintVectr(int[] vector)
		{

			for (int q = 0; q < vector.Length; q++)
			{
				Console.Write(vector[q] + " ");
			}
			Console.WriteLine();
		}
		static int[] Vect()
		{
			Console.Write("Введите размерность (должна равняться строкам массива): ");
			int n = int.Parse(Console.ReadLine());
			int[] vector = new int[n];
			Random rand = new Random();
			for (int q = 0; q < vector.Length; q++)
			{
				vector[q] = rand.Next(0, 10);
			}
			return vector;
		}


		static int[,] decision(int[,] mass, int[] vector)
		{
			int[,] result = new int[mass.GetLength(0), mass.GetLength(1)];
				for (int i = 0; i < mass.GetLength(0); i++)
				{
					for (int j = 0; j < mass.GetLength(1); j++)
					{
						result[i,j] += mass[i, j] * vector[i];
						Console.Write(result[i,j] + " ");
					}
					Console.WriteLine();
				}
			return result;
		}

		static void Main(string[] args)
		{
			try
			{
				int[,] Massive = Mass();
				int[] Vector = Vect();
				Console.Write("Исходный массив: " + "\n");
				PrintMass(Massive);
				Console.Write("Исходный вектор: " + "\n");
				PrintVectr(Vector);
				Console.Write("Перемноженный вектор на массив: " + "\n");
				decision(Massive, Vector);
			}
			catch
			{
				Console.WriteLine("Неверные данные");
			}
		}
	}
}
