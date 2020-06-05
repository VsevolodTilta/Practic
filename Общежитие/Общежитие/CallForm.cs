using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Data.OleDb;

namespace Общежитие
{
	public partial class CallForm : Form
	{
		public CallForm()
		{
			InitializeComponent();
		}

		private void buttonCall_Click(object sender, EventArgs e)
		{
			OleDbConnection sqlconn = new OleDbConnection("Provider = Microsoft.ACE.OLEDB.12.0;" + "Data source = C:/Users/Admin/Desktop/Общежитие.accdb");
			sqlconn.Open();
			string s = "";
			if(radioButtonFullInfo.Checked) { s = "SELECT * FROM Student"; }
			if (radioButtonInfo.Checked) { s = "SELECT SNP, Group FROM Student"; }
			if(radioButtonGroup.Checked) { s = "SELECT DISTINCT Group FROM Student"; }
			if (radioButtonFloor.Checked) { s = "SELECT * FROM room where Floor = 3"; }
			if (radioButtonPO.Checked) { s = "SELECT * FROM Student where Student.Group like 'ПО%'"; }
			OleDbDataAdapter oda = new OleDbDataAdapter(s, sqlconn);
			DataTable dt = new DataTable();
			oda.Fill(dt);
			dataGridView1.DataSource = dt;
			sqlconn.Close();
		}

		private void buttonClear_Click(object sender, EventArgs e)
		{
			int count = dataGridView1.Columns.Count;
			for (int i = 0; i < count; i++)
			{
				dataGridView1.Columns.RemoveAt(0);
			}
		}
	}
}
