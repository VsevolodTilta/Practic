using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Общежитие
{
	public partial class Form1 : Form
	{
		public Form1()
		{
			InitializeComponent();
		}

		private void roomToolStripMenuItem_Click(object sender, EventArgs e)
		{
			roomForm room = new roomForm();
			room.ShowDialog();
		}

		private void lgotToolStripMenuItem_Click(object sender, EventArgs e)
		{
			lgotForm lgot = new lgotForm();
			lgot.ShowDialog();
		}

		private void ResettlementToolStripMenuItem_Click(object sender, EventArgs e)
		{
			ResettlementForm res = new ResettlementForm();
			res.ShowDialog();
		}

		private void ExitFromProgr_Click(object sender, EventArgs e)
		{
			this.Close();
		}

		private void studentToolStripMenuItem_Click_1(object sender, EventArgs e)
		{
			studentForm studnet = new studentForm();
			studnet.ShowDialog();
		}

		private void Form1_Load(object sender, EventArgs e)
		{
				this.ControlBox = false;
		}

		Point lastPoint;
		private void Form1_MouseMove(object sender, MouseEventArgs e)
		{
			if(e.Button == MouseButtons.Left)
			{
				this.Left += e.X - lastPoint.X;
				this.Top += e.Y - lastPoint.Y;
			}
		}

		private void Form1_MouseDown(object sender, MouseEventArgs e)
		{
			lastPoint = new Point(e.X, e.Y);
		}

		private void CallToolStripMenuItem_Click(object sender, EventArgs e)
		{
			CallForm call = new CallForm();
			call.ShowDialog();
		}

		private void ReportToolStripMenuItem_Click(object sender, EventArgs e)
		{
			ReportForm2 report = new ReportForm2();
			report.ShowDialog();
		}
	}
}
