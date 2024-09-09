using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace GerenciadorDeTickets.Relatorios.WinForms
{
    public partial class TotalTicketsFuncionario : Form
    {
        DataTable dt = new DataTable();
        string total;
        public TotalTicketsFuncionario(DataTable dt, string total)
        {
            InitializeComponent();
            this.total = total;
            this.dt = dt;
        }

        private void TotalTicketsByFuncionario_Load(object sender, EventArgs e)
        {

            this.rvTotalTickets.LocalReport.DataSources.Clear();
            this.rvTotalTickets.LocalReport.DataSources.Add(new Microsoft.Reporting.WinForms.ReportDataSource("TotalTickets", dt));

            this.rvTotalTickets.LocalReport.SetParameters(new Microsoft.Reporting.WinForms.ReportParameter("TotalTickets", total));
            this.rvTotalTickets.RefreshReport();
        }
    }
}
