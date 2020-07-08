using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Zad_11
{
	public partial class Form1 : Form
	{
		public Form1()
		{
			InitializeComponent();
		}

		private void button1_Click(object sender, EventArgs e)
		{
			int nom = int.Parse(textBox1.Text);
			int sum = int.Parse(textBox2.Text);
			Money cash = new Money(nom, sum);
			richTextBox1.Text += cash + "\n";
			int price = int.Parse(textBox3.Text);
			richTextBox1.Text += cash.CheckAvailability(price) + "\n";
			int sumItem = int.Parse(textBox4.Text);
			richTextBox1.Text += cash.CalculationOfQuantity(sumItem) +"\n";
		}
	}
}
