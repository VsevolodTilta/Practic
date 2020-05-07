using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp17
{
	class Program
	{
		static void Main(string[] args)
		{
			Console.Write("Введите номер карты: ");
			int h = byte.Parse(Console.ReadLine());
			switch (h)
			{
				case 6: 
					Console.WriteLine("Карта - Туз");
					break;
				case 7:
					Console.WriteLine("Карта - Семерка");
					break;
				case 8:
					Console.WriteLine("Карта - Восьмерка");
					break;
				case 9:
					Console.WriteLine("Карта - Девятка");
					break;
				case 10:
					Console.WriteLine("Карта - Десятка");
					break;
				case 11:
					Console.WriteLine("Карта - Валет");
					break;
				case 12:
					Console.WriteLine("Карта - Дама");
					break;
				case 13:
					Console.WriteLine("Карта - Король");
					break;
				case 14:
					Console.WriteLine("Карта - Туз");
					break;
				default:
					Console.WriteLine("Таких карт не существует");
					break;
			}
			Console.ReadKey();
		}
	}
}
