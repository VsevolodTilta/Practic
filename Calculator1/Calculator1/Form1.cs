using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Calculator1
{
	public partial class Form1 : Form
	{
		public Form1()
		{
			InitializeComponent();
		}

		public double a, b;
		int count;

		private void button1_Click(object sender, EventArgs e)
		{
			textBox1.Text += "1";
		}

		private void button2_Click(object sender, EventArgs e)
		{
			textBox1.Text += "2";
		}

		private void button3_Click(object sender, EventArgs e)
		{
			textBox1.Text += "3";
		}

		private void button4_Click(object sender, EventArgs e)
		{
			textBox1.Text += "4";
		}

		private void button5_Click(object sender, EventArgs e)
		{
			textBox1.Text += "5";
		}

		private void button6_Click(object sender, EventArgs e)
		{
			textBox1.Text += "6";
		}

		private void button7_Click(object sender, EventArgs e)
		{
			textBox1.Text += "7";
		}

		private void button8_Click(object sender, EventArgs e)
		{
			textBox1.Text += "8";
		}

		private void button9_Click(object sender, EventArgs e)
		{
			textBox1.Text += "9";
		}

		private void button0_Click(object sender, EventArgs e)
		{
			textBox1.Text += "0";
		}

		private void button00_Click(object sender, EventArgs e)
		{
			textBox1.Text += "00";
		}

		private void buttonPlus_Click(object sender, EventArgs e)
		{
			try
			{
				a = double.Parse(textBox1.Text);
				textBox1.Clear();
				count = 1;
				label1.Text = a.ToString() + "+";
			}
			catch
			{
				MessageBox.Show("Не введены данные");
			}
		}

		private void buttonMinus_Click(object sender, EventArgs e)
		{
			try
			{
				a = double.Parse(textBox1.Text);
				textBox1.Clear();
				count = 2;
				label1.Text = a.ToString() + "-";
			}
			catch
			{
				MessageBox.Show("Не введены данные");
			}
		}

		private void buttonMult_Click(object sender, EventArgs e)
		{
			try
			{
				a = double.Parse(textBox1.Text);
				textBox1.Clear();
				count = 3;
				label1.Text = a.ToString() + "*";
			}
			catch
			{
				MessageBox.Show("Не введены данные");
			}
		}

		private void buttonShare_Click(object sender, EventArgs e)
		{
			try
			{
				a = double.Parse(textBox1.Text);
				textBox1.Clear();
				count = 4;
				label1.Text = a.ToString() + "/";
			}
			catch
			{
				MessageBox.Show("Не введены данные");
			}
		}

		private void buttonEqually_Click(object sender, EventArgs e)
		{
			calculate();
			label1.Text = "";
		}

		private void calculate()
		{
			try
			{
				switch (count)
				{
					case 1:
						b = a + double.Parse(textBox1.Text);
						textBox1.Text = b.ToString();
						break;
					case 2:
						b = a - double.Parse(textBox1.Text);
						textBox1.Text = b.ToString();
						break;
					case 3:
						b = a * double.Parse(textBox1.Text);
						textBox1.Text = b.ToString();
						break;
					case 4:
						b = a / double.Parse(textBox1.Text);
						textBox1.Text = b.ToString();
						break;
					case 5:
						b = Convert.ToDouble(Math.Pow(a, double.Parse(textBox1.Text)));
						textBox1.Text = b.ToString();
						break;
				}
			}
			catch (Exception)
			{

			}
		}

		private void buttonDegree_Click(object sender, EventArgs e)
		{
			try
			{
				a = double.Parse(textBox1.Text);
				textBox1.Clear();
				count = 5;
				label1.Text = a.ToString() + "^";
			}
			catch
			{
				MessageBox.Show("Не введены данные");
			}
		}

		private void buttonRadical_Click(object sender, EventArgs e)
		{
			try
			{
				a = double.Parse(textBox1.Text);
				label1.Text = a.ToString() + "√";
				textBox1.Text = Convert.ToString(Math.Sqrt(a));
			}
			catch
			{
				MessageBox.Show("Не введены данные");
			}
		}

		private void buttonSin_Click(object sender, EventArgs e)
		{
			try
			{
				a = double.Parse(textBox1.Text);
				label1.Text = a.ToString() + "sin ";
				textBox1.Text = Convert.ToString(Math.Sin((a * Math.PI) / 180));
			}
			catch
			{
				MessageBox.Show("Не введены данные");
			}
		}

		private void buttonCos_Click(object sender, EventArgs e)
		{
			try
			{
				a = double.Parse(textBox1.Text);
				label1.Text = a.ToString() + "cos ";
				textBox1.Text = Convert.ToString(Math.Cos((a * Math.PI) / 180));
			}
			catch
			{
				MessageBox.Show("Не введены данные");
			}
		}

		private void buttonTg_Click(object sender, EventArgs e)
		{
			try
			{
				a = double.Parse(textBox1.Text);
				label1.Text = a.ToString() + "tg ";
				textBox1.Text = Convert.ToString(Math.Tan((a * Math.PI) / 180));
			}
			catch
			{
				MessageBox.Show("Не введены данные");
			}
		}

		private void buttonCTg_Click(object sender, EventArgs e)
		{
			try
			{
				a = double.Parse(textBox1.Text);
				label1.Text = a.ToString() + "ctg ";
				textBox1.Text = Convert.ToString((Math.Cos((a * Math.PI) / 180)) / (Math.Sin((a * Math.PI) / 180)));
			}
			catch
			{
				MessageBox.Show("Не введены данные");
			}
		}

		private void buttonClear_Click(object sender, EventArgs e)
		{
			textBox1.Text = "";
			label1.Text = "";
		}

		private void buttonDelete_Click(object sender, EventArgs e)
		{
			try
			{
				string s = textBox1.Text;
				s = s.Substring(0, s.Length - 1);
				textBox1.Text = s;
			}
			catch
			{
				MessageBox.Show("Нечего удалять");
			}
		}

	}
}
