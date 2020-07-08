using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Zad_12
{
	public partial class Form1 : Form
	{
		public Form1()
		{
			InitializeComponent();
		}

		private void button1_Click(object sender, EventArgs e)
		{
			Money cash = new Money();
			int n = int.Parse(textBox1.Text);
			try
			{
				richTextBox1.Text += cash[n];
			}
			catch (Exception ex)
			{
				MessageBox.Show(ex.Message);
			}
			richTextBox1.Text +=cash + "\n";
			
			int price = int.Parse(textBox2.Text);
			richTextBox1.Text += cash.CheckAvailability(price) + "\n";
			int sumItem = int.Parse(textBox3.Text);
			richTextBox1.Text += cash.CalculationOfQuantity(sumItem) + "\n";
			richTextBox1.Text += cash++ + "\n";
			richTextBox1.Text += cash-- + "\n";
			if (!cash)
			{
				richTextBox1.Text += "Поле \"second\" не нулевое" + "\n";
			}
			else
			{
				richTextBox1.Text += "Поле \"second\" нулевое" + "\n";
			}
			richTextBox1.Text += cash + 35 + "\n";
			richTextBox1.Text += (string)cash + "\n";
			richTextBox1.Text += (Money)"1 2" + "\n";
		}
	}
}
