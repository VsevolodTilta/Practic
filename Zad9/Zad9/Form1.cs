using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.IO;

namespace Zad9
{
	public partial class Form1 : Form
	{
		public Form1()
		{
			InitializeComponent();
		}

		private void button1_Click(object sender, EventArgs e)
		{
			try
			{
				int n = int.Parse(textBox1.Text);
				int[] mass = new int[n];
				Random rand = new Random();
				string FileName = @"FileFor.dat";
				richTextBox1.Text += "Предоставленные числа: ";
				for (int i = 0; i < mass.Length; i++)
				{
					mass[i] = rand.Next(-5, 15);
					richTextBox1.Text +=(mass[i] + " ");
				}

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
					richTextBox1.Text += ("\n" + "Четные числа последовательности: ");
					while ((line = sr.ReadLine()) != null)
					{
						richTextBox1.Text += line;
					}
				}
			}
			catch
			{
				MessageBox.Show("Неверные данные");
			}
		}

		private void button2_Click(object sender, EventArgs e)
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
				richTextBox2.Text += $"Самой длинной является {str} строка";
			}
			catch
			{
				MessageBox.Show("Неверные данные");
			}
		}
	}
}
