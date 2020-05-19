using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Text.RegularExpressions;

namespace Zad8
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
				string retVal = Regex.Replace(textBox1.Text, @"\b\w\b", "");
				retVal = Regex.Replace(retVal, @"\s+", " ");
				label2.Text = "Измененная строка: " + retVal;
			}
			catch
			{
				MessageBox.Show("Неверные данные");
			}
		}
	}
}
