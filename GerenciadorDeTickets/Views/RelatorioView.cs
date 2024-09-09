using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Runtime.InteropServices.WindowsRuntime;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace GerenciadorDeTickets.Views
{
    public partial class RelatorioView : Form, IRelatorioView
    {
        public RelatorioView()
        {
            InitializeComponent();
            AssociateAndRaiseViewEvents();
            cbAgrupar.Visible = false;
        }

        private void AssociateAndRaiseViewEvents()
        {
            btnGerar.Click += delegate
            {
                LoadRelatorioEvent?.Invoke(this, EventArgs.Empty);
            };

            btnImprimir.Click += delegate
            {
                PrintEvent?.Invoke(this, EventArgs.Empty);
            };

            txtFuncionarioId.Leave += delegate { FuncionarioId_Leave?.Invoke(this, EventArgs.Empty); };
            btnFechar.Click += delegate { CloseForm(); };
        }


        public  void CloseForm()
        {
            this.Close();
        }
        public DateTime DataInicio 
        {
            get { return dtInicial.Value; } 
            set {  dtInicial.Value = value; }
        }
        public DateTime DataFim 
        {
            get { return dtFinal.Value; }
            set { dtFinal.Value = value; }
        }
        public string FuncionarioId 
        { 
            get { return txtFuncionarioId.Text; } 
            set {  txtFuncionarioId.Text = value;} 
        }
        public string FuncionarioNome
        {
            get { return txtFuncionairoNome.Text; }
            set { txtFuncionairoNome.Text = value; }
        }

        public string TotalQuantidadeTickets
        {
            get { return lblTotalQuantidadeTickets.Text; }
            set { lblTotalQuantidadeTickets.Text = value; }
        }

        public bool IsChecked 
        {
            get { return cbAgrupar.Checked; }
            set { cbAgrupar.Checked = value; }
        }
        public void SetDadosBidingSource(BindingSource dataList)
        {
            dgvRelatorio.DataSource = dataList;
        }

        public event EventHandler<EventArgs> LoadRelatorioEvent;
        public event EventHandler<EventArgs> FuncionarioId_Leave;
        public event EventHandler<EventArgs> PrintEvent;

        private static RelatorioView instance;
        public static RelatorioView GetInstance(Form parentContainer)
        {
            if (instance == null || instance.IsDisposed)
            {
                instance = new RelatorioView();
                instance.MdiParent = parentContainer;
                instance.FormBorderStyle = FormBorderStyle.None;
                instance.Dock = DockStyle.Fill;
            }
            else
            {
                if (instance.WindowState == FormWindowState.Minimized)
                {
                    instance.WindowState = FormWindowState.Normal;
                }
                instance.BringToFront();
            }
            return instance;
        }

        private void cbTodos_CheckedChanged(object sender, EventArgs e)
        {
            if (cbTodos.Checked) 
            {
                txtFuncionarioId.Enabled = false;
                txtFuncionarioId.Text = "0";
                txtFuncionairoNome.Text = "Todos";

                cbAgrupar.Enabled = true;
                cbAgrupar.Visible = true;

            }
            else
            {
                txtFuncionarioId.Enabled = true;
                txtFuncionairoNome.Text = "";
                cbAgrupar.Enabled = false;
                cbAgrupar.Visible = false;
                cbAgrupar.Checked = false;
            }
        }
    }
}
