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
	public partial class Lesson1 : Form
	{
		public Lesson1()
		{
			InitializeComponent();
		}

		private void button1_Click(object sender, EventArgs e)
		{
			int result = int.Parse(textBox1.Text) / int.Parse(textBox2.Text);
			label1.Text = result.ToString();
		}

	}
}
