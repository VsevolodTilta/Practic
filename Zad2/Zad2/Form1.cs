using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Zad2
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
				float x = float.Parse(textBox1.Text);
				float y = float.Parse(textBox2.Text);

				if (x * x + y * y > 9 && x * x + y * y < 49)
					label3.Text = "Внутри фигуры";
				else if (x * x + y * y < 9 || x * x + y * y > 49)
					label3.Text = "Вне границ фигуры";
				else
					label3.Text = "На границе фигуры";
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
				byte h = byte.Parse(textBox3.Text);
				switch (h)
				{
					case 6:
						label5.Text = "Карта - Шестерка";
						break;
					case 7:
						label5.Text = "Карта - Семерка";
						break;
					case 8:
						label5.Text = "Карта - Восьмерка";
						break;
					case 9:
						label5.Text = "Карта - Девятка";
						break;
					case 10:
						label5.Text = "Карта - Десятка";
						break;
					case 11:
						label5.Text = "Карта - Валет";
						break;
					case 12:
						label5.Text = "Карта - Дама";
						break;
					case 13:
						label5.Text = "Карта - Король";
						break;
					case 14:
						label5.Text = "Карта - Туз";
						break;
					default:
						label5.Text = "Таких карт не существует";
						break;
				}
			}
			catch
			{
				MessageBox.Show("Неверные данные");
			}
		}

		private void button3_Click(object sender, EventArgs e)
		{
			try
			{
				byte n = byte.Parse(textBox4.Text);
				int i = 453;
				richTextBox1.Text += "While: \n";
				while (i <= n * 453)
				{
					richTextBox1.Text += i / 453 + " ф" + " = " + i + " гр" + "\n";
					i += 453;
				}

				i = 453;
				richTextBox1.Text += "Do while: \n";
				do
				{
					richTextBox1.Text += i / 453 + " ф" + " = " + i + " гр" + "\n";
					i += 453;
				}
				while (i <= n * 453);

				richTextBox1.Text += "For: \n";
				for (i = 453; i <= n * 453; i += 453)
				{
					richTextBox1.Text += i / 453 + " ф" + " = " + i + " гр" + "\n";
				}
			}
			catch
			{
				MessageBox.Show("Неверные данные");
			}
		}

		private void button4_Click(object sender, EventArgs e)
		{
			try
			{
				int i, j;
				int num = int.Parse(textBox5.Text);
				int d = 1;
				for (i = 0; i < 5; i++)
				{
					for (j = 0; j < d; j++)
					{
						richTextBox2.Text += num + "  ";
					}
					d++;
					richTextBox2.Text += "\n";
				}
			}
			catch
			{
				MessageBox.Show("Неверные данные");
			}
		}

	}
}
