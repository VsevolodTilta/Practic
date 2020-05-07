using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp22
{
	class Program
	{
		static void Main(string[] args)
		{
            int i, j;
            int num = 7;
            int d = 1;
            for (i = 0; i < 5; i++)
            {
                for (j = 0; j < d; j++)
                {
                    Console.Write(num + "  ");
                }
                d++;
                Console.WriteLine();
            }
            Console.ReadLine();
        }
	}
}
