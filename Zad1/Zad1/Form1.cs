using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Zad1
{
	public partial class Form1 : Form
	{
		public Form1()
		{
			InitializeComponent();
		}

		private void button1_Click_1(object sender, EventArgs e)
		{
			try
			{
				double a = double.Parse(textBox1.Text);
				double b = double.Parse(textBox2.Text);
				double p = Math.Sqrt(Math.Abs(a * b));

				label3.Text = "Среднее геометрическое \n модулей = " + p;
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
				int h = int.Parse(textBox3.Text);
				if (h % 10 == 7)
					label5.Text = "Число оканчивается на 7";
				else
					label5.Text = "Число не оканчивается на 7";
			}
			catch
			{
				MessageBox.Show("Неверные данные");
			}
		}
	}
}
