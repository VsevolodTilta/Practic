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
	public partial class roomForm : Form
	{
		public roomForm()
		{
			InitializeComponent();
		}

		private void roomForm_Load(object sender, EventArgs e)
		{
			// TODO: данная строка кода позволяет загрузить данные в таблицу "общежитиеDataSet.room". При необходимости она может быть перемещена или удалена.
			this.roomTableAdapter.Fill(this.общежитиеDataSet.room);
			// TODO: данная строка кода позволяет загрузить данные в таблицу "общежитиеDataSet.room". При необходимости она может быть перемещена или удалена.
			this.roomTableAdapter.Fill(this.общежитиеDataSet.room);

		}

		private void buttonRefresh_Click(object sender, EventArgs e)
		{
			roomTableAdapter.Update(общежитиеDataSet);
		}
	}
}
