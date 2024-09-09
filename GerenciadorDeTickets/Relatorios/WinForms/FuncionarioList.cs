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

    public partial class FuncionarioList : Form
    {
        DataTable dt = new DataTable();
        public FuncionarioList(DataTable dt)
        {
            InitializeComponent();
            this.dt = dt;
        }

        private void FrmFuncionarioRelatorio_Load(object sender, EventArgs e)
        {
            this.reportViewer1.LocalReport.DataSources.Clear();
            this.reportViewer1.LocalReport.DataSources.Add(new Microsoft.Reporting.WinForms.ReportDataSource("Funcionario", dt));
            this.reportViewer1.RefreshReport();
        }
    }
}
