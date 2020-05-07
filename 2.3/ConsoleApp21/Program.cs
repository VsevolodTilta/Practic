using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp21
{
	class Program
	{
		static void Main(string[] args)
		{
            try
            {
                Console.Write("Введите количество фунтов: ");
                byte n = byte.Parse(Console.ReadLine());
                int i = 453;
                Console.WriteLine("While: ");
                while (i <= n * 453)
                {
                    Console.WriteLine(i / 453 + " = " + i);
                    i += 453;
                }

                i = 453;
                Console.WriteLine("Do while: ");
                do
                {
                    Console.WriteLine(i / 453 + " = " + i);
                    i += 453;
                }
                while (i <= n * 453);

                Console.WriteLine("For: ");
                for (i = 453; i <= n * 453; i += 453)
                {
                    Console.WriteLine(i / 453 + " = " + i);
                }

                Console.ReadKey();
            }
            catch
            {
                Console.WriteLine("Неверные данные");
                Console.ReadKey();
            }
        }
    }
}
