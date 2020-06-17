using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace lessons
{
	public partial class Lesson26 : Form
	{
		public Lesson26()
		{
			InitializeComponent();
		}

		private void button1_Click(object sender, EventArgs e)
		{
			Form2 f = new Form2();
			if (f.ShowDialog() == DialogResult.OK)
			{
				textBox1.Text = f.textBox1.Text;
			}
		}
	}
}
