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
	public partial class studentForm : Form
	{
		public studentForm()
		{
			InitializeComponent();
		}

		private void studentForm_Load(object sender, EventArgs e)
		{
			// TODO: данная строка кода позволяет загрузить данные в таблицу "общежитиеDataSet.Student". При необходимости она может быть перемещена или удалена.
			this.studentTableAdapter.Fill(this.общежитиеDataSet.Student);

		}

		private void buttonRefresh_Click(object sender, EventArgs e)
		{
			studentTableAdapter.Update(общежитиеDataSet);
		}
	}
}
