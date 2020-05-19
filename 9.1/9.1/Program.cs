using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;

namespace _9._1
{
	class Program
	{
		static void Main(string[] args)
		{
			try
			{
				Console.Write("Введите кол-во элементов: ");
				int n = int.Parse(Console.ReadLine());
				int[] mass = new int[n];
				Random rand = new Random();
				string FileName = @"FileFor.dat";
				Console.Write("Предоставленные числа: ");
				for (int i = 0; i < mass.Length; i++)
				{
					mass[i] = rand.Next(-5, 15);
					Console.Write(mass[i] + " ");
				}
				Console.WriteLine();

				using (StreamWriter sw = new StreamWriter(FileName))
				{
					foreach (int i in mass)
					{
						if (i % 2 == 0)
						{
							sw.Write(i + " ");
						}
					}
				}
				using (StreamReader sr = new StreamReader(FileName))
				{
					string line;
					Console.Write("Четные числа последовательности: ");
					while ((line = sr.ReadLine()) != null)
					{
						Console.WriteLine(line);
					}
				}
			}
			catch
			{
				Console.WriteLine("Неверные данные");
			}
			Console.ReadKey();
		}
	}
}
