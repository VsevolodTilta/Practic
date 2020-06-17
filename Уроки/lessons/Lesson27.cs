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
	public partial class Lesson27 : Form
	{
		public Lesson27()
		{
			InitializeComponent();
		}

		Color color;
		int[] customColors = new int[] { 0xFF0000, 0xFFFF00, 0xFF00FF };


		private void button1_Click(object sender, EventArgs e)
		{
			colorDialog1.CustomColors = customColors;
			if (colorDialog1.ShowDialog() == DialogResult.OK)
			{
				customColors = colorDialog1.CustomColors;
				color = colorDialog1.Color;
			}
		}
	}
}
