using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp18
{
	class Program
	{
		static int [] Mass()
		{
			Console.Write("Введите количество элементов массива: ");
			int n = int.Parse(Console.ReadLine());
			int[] mass = new int[n];

			for (int i = 0; i < mass.Length; i++)
			{
				Console.Write("mass[{0}]= ", i);
				mass[i] = int.Parse(Console.ReadLine());
			}
			return mass;
		}
		
		static void Print(int[] mass)
		{
			for (int i = 0; i < mass.Length; i++)
			{
				Console.Write("{0}" + " ", mass[i]);
			}
		}

		static int Max(int[] mass)
		{
			int max = 0;
			int indexMax = 0;
			for (int i = 0; i < mass.Length; i++)
			{
				if (mass[i] > max)
				{
					indexMax = i;
					max = mass[i];
				}
			}
			return indexMax;
		}

		static void Change(int[] mass, int index)
		{
			int buffer = mass[index];
			mass[index] = mass[0];
			mass[0] = buffer;
		}

		static void Main(string[] args)
		{
			try
			{
				int[] Massive = Mass();
				Console.WriteLine("Исходный массив: ");
				Print(Massive);
				int indexMax = Max(Massive);
				Console.Write("Максимальный элемент массива: " + Massive[indexMax]);
				Console.WriteLine();
				Console.Write("Измененный массив: ");
				Change(Massive, indexMax);
				Print(Massive);
			}
			catch
			{
				Console.WriteLine("Неверные данные");
			}
			Console.ReadKey();
		}
	}
}
