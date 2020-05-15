using System;
using System.Collections.Generic;
using System.Linq;
using System.Linq.Expressions;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp5
{
	class Program
	{
		static int [] Mass()
		{
			Console.Write("Введите количество элементов массива: ");
			int n = int.Parse(Console.ReadLine());
			int[] mass = new int[n];
			Random rand = new Random();
			for (int i = 0; i < mass.Length; i++)
			{
				mass[i] = rand.Next(0, 10);
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

		static void Change(int [] mass)
		{
			Console.Write("Введите число для изменения: ");
			int numb = int.Parse(Console.ReadLine());
			for (int i = 0; i < mass.Length; i++)
			{
				if (mass[i] > numb)
					mass[i] = (int)mass[i]*2;
			}
		}

		static void Main(string[] args)
		{
			try
			{
				int[] Massive = Mass();
				Console.Write("Исходный массив: ");
				Print(Massive);
				Console.WriteLine();
				Change(Massive);
				Console.WriteLine("Измененный массив: ");
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
