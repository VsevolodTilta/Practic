using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _11
{
	class Program
	{
		static void Main(string[] args)
		{
			Console.Write("Введите номинал купюр: ");
			int nom = int.Parse(Console.ReadLine());
			Console.Write("Введите количество купюр: ");
			int sum = int.Parse(Console.ReadLine());
			Money cash = new Money(nom, sum);
			Console.WriteLine(cash);
			Console.Write("Введите стоимость желаемого товара: ");
			int price = int.Parse(Console.ReadLine());
			Console.WriteLine(cash.CheckAvailability(price));
			Console.Write("Введите кол-во желаемого товара: ");
			int sumItem = int.Parse(Console.ReadLine());
			Console.WriteLine(cash.CalculationOfQuantity(sumItem));

			Console.ReadKey();
		}
	}
}
