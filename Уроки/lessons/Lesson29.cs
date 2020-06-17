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
	public partial class Lesson29 : Form
	{
		public Lesson29()
		{
			InitializeComponent();
		}

		Font userFont = DefaultFont;

		
		protected override void OnPaint(PaintEventArgs e)
		{
			Graphics g = e.Graphics;
			g.DrawString("Test", userFont, Brushes.Blue, 20, 20);
			base.OnPaint(e);
		}

		private void button1_Click_1(object sender, EventArgs e)
		{
			if (fontDialog1.ShowDialog() == DialogResult.OK)
			{
				userFont = fontDialog1.Font;
				Invalidate();
			}

		}
	}
}
