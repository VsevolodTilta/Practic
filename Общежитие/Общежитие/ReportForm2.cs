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
	public partial class ReportForm2 : Form
	{
		public ReportForm2()
		{
			InitializeComponent();
		}

		private void ReportForm2_Load(object sender, EventArgs e)
		{
			// TODO: данная строка кода позволяет загрузить данные в таблицу "ОбщежитиеDataSet.Student". При необходимости она может быть перемещена или удалена.
			this.StudentTableAdapter.Fill(this.ОбщежитиеDataSet.Student);

			this.reportViewer1.RefreshReport();
			this.reportViewer1.RefreshReport();
		}
	}
}
