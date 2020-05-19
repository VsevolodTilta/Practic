using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _7._1
{
	class Program
	{
		static void Main(string[] args)
		{
            try
            {
                Console.Write("Введите строку: ");
                string input = Console.ReadLine();
                int ind = 0;
                for (int i = 0; i < input.Length; i++)
                {
                    if (input.Substring(i, 1) != " ")
                        ind++;
                }
                Console.WriteLine($"{ind} букв в строке");
            }
            catch
            {
                Console.WriteLine("Неверные данные");
            }
            Console.ReadKey();
        }
	}
}
