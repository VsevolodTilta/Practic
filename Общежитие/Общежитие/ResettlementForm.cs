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
	public partial class ResettlementForm : Form
	{
		public ResettlementForm()
		{
			InitializeComponent();
		}

		private void roomBindingNavigatorSaveItem_Click(object sender, EventArgs e)
		{
			this.Validate();
			this.roomBindingSource.EndEdit();
			this.tableAdapterManager.UpdateAll(this.общежитиеDataSet);

		}

		private void ResettlementForm_Load(object sender, EventArgs e)
		{
			// TODO: данная строка кода позволяет загрузить данные в таблицу "общежитиеDataSet.Student". При необходимости она может быть перемещена или удалена.
			this.studentTableAdapter.Fill(this.общежитиеDataSet.Student);
			// TODO: данная строка кода позволяет загрузить данные в таблицу "общежитиеDataSet.room". При необходимости она может быть перемещена или удалена.
			this.roomTableAdapter.Fill(this.общежитиеDataSet.room);

		}

		private void button1_Click(object sender, EventArgs e)
		{
			if (MessageBox.Show("Вы действительно хотите применить изменения?", "Изменения данных", MessageBoxButtons.YesNo) == DialogResult.Yes)
			{
				roomBindingSource.EndEdit();
				roomTableAdapter.Update(общежитиеDataSet);
				studentTableAdapter.Update(общежитиеDataSet);
			}
		}
	}
}
