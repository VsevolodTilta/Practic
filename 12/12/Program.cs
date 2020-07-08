using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _12
{
	class Program
	{
		static void Main(string[] args)
		{
			Money cash = new Money();
			Console.Write("Введите номер индекса: ");
			int n = int.Parse(Console.ReadLine());
			try
			{
				Console.WriteLine(cash[n]);
			}
			catch(Exception ex)
			{
				Console.WriteLine(ex.Message);
			}
			Console.WriteLine(cash);
			Console.Write("Введите стоимость желаемого товара: ");
			int price = int.Parse(Console.ReadLine());
			Console.WriteLine(cash.CheckAvailability(price));
			Console.Write("Введите кол-во желаемого товара: ");
			int sumItem = int.Parse(Console.ReadLine());
			Console.WriteLine(cash.CalculationOfQuantity(sumItem));
			Console.WriteLine(cash++);
			Console.WriteLine(cash--);
			if(!cash)
			{
				Console.WriteLine("Поле \"second\" не нулевое");
			}
			else
			{
				Console.WriteLine("Поле \"second\" нулевое");
			}
			Console.WriteLine(cash+35);
			Console.WriteLine((string)cash);
			Console.WriteLine((Money)"1 2");
			Console.ReadKey();
		}
	}
}
