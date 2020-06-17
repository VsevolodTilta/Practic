using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Drawing.Drawing2D;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;


namespace lessons
{
	public partial class Lesson12 : Form
	{
		public Lesson12()
		{
			InitializeComponent();
		}

		private void Lesson12_Load(object sender, EventArgs e)
		{
			GraphicsPath gp = new GraphicsPath();
			gp.AddEllipse(0, 0, 100, 100);
			gp.AddEllipse(110, 0, 100, 100);
			Region r = new Region(gp);
			this.Region = r;	

		}
	}
}
