using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp20
{
	class Program
	{
		static void Main(string[] args)
		{
			try
			{
				Console.Write("Введите x координату: ");
				float x = float.Parse(Console.ReadLine());
				Console.Write("Введите y координату: ");
				float y = float.Parse(Console.ReadLine());

				if (x * x + y * y > 9 && x * x + y * y < 49)
					Console.WriteLine("Внутри");
				else if (x * x + y * y < 9 || x * x + y * y > 49)
					Console.WriteLine("Вне");
				else
					Console.WriteLine("На границе");

				Console.ReadLine();
			}
			catch
			{
				Console.WriteLine("Неверные данные");
				Console.ReadLine();
			}
		}
	}
}
