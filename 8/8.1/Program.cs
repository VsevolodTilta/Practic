using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;

namespace _8._1
{
	class Program
	{
		static void Main(string[] args)
		{
			try
			{
				Console.Write("Введите строку: ");
				string retVal = Regex.Replace(Console.ReadLine(), @"\b\w\b", "");
				retVal = Regex.Replace(retVal, @"\s+", " ");
				Console.Write("Измененная строка: " + retVal);
			}
			catch
			{
				Console.WriteLine("Неверные данные");
			}
			Console.ReadLine();
		}
	}
}
