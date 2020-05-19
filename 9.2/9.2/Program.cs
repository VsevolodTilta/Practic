using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;

namespace _9._2
{
	class Program
	{
		static void Main(string[] args)
		{
			try
			{
				var lines = File.ReadAllLines(@"FileStr.txt");
				var max = int.MinValue;
				var str = 0;

				foreach (var line in lines)
					if (line.Length > max)
					{
						max = line.Length;
						str++;
					}
				Console.WriteLine($"Самой длинной является {str} строка");
			}
			catch
			{
				Console.WriteLine("Неверные данные");
			}
			Console.ReadKey();
		}
	}
}
