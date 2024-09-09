using GerenciadorDeTickets.Models;
using GerenciadorDeTickets.Relatorios.WinForms;
using Org.BouncyCastle.Asn1.Ocsp;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Drawing.Printing;
using System.Linq;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices.WindowsRuntime;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Windows.Forms.VisualStyles;

namespace GerenciadorDeTickets.Views
{
    public partial class FuncionarioView : Form, IFuncionarioView
    {
        public string FuncionarioId
        {
            get { return lblId.Text; }
            set { lblId.Text = value; }
        }
        public string FuncionarioNome
        {
            get { return txtNome.Text; }
            set { txtNome.Text = value; }
        }
        public string FuncionarioCpf
        {
            get { return txtCpf.Text; }
            set { txtCpf.Text = value; }
        }
        public string FuncionarioSituacao
        {
            get { return (((KeyValuePair<string, string>)cbSituacao.SelectedItem).Value); }
            set
            {
                foreach (KeyValuePair<string, string> item in cbSituacao.Items)
                {
                    if (item.Value == value)
                    {
                        cbSituacao.SelectedItem = item;
                        break;
                    }
                }
            }
        }
        public string FuncionarioDataAlteracao
        {
            get { return txtData.Text; }
            set { txtData.Text = value; }
        }
        public string SearchValue
        {
            get { return txtBuscar.Text; }
            set { txtBuscar.Text = value; }
        }
        public bool IsEdit { get; set; }
        public bool IsSuccessful { get; set; }
        public string Message { get; set; }

        public FuncionarioView()
        {
            InitializeComponent();
            AssociateAndRaiseViewEvents();
            AjustarSituacao();
            tabControl1.TabPages.Remove(tpFuncionarioDetalhes);
        }

        private void AssociateAndRaiseViewEvents()
        {
            btnBuscar.Click  += delegate 
            { 
                SearchEvent?.Invoke(this, EventArgs.Empty);

            };
            btnNovo.Click    += delegate 
            { 
                AddNewEvent?.Invoke(this, EventArgs.Empty);
                tabControl1.TabPages.Remove(tpFuncionarioList);
                tabControl1.TabPages.Add(tpFuncionarioDetalhes);
                tpFuncionarioDetalhes.Text = "Adicionar Funcionario";

                cbSituacao.SelectedIndex = 0;
                cbSituacao.Enabled = false;

                txtData.Visible = false;
                txtData.Enabled = false;

                lblTxtData.Visible = false;
                
            };
            btnAlterar.Click += delegate 
            { 
                if(dgvFuncionarios.Rows.Count > 0)
                {
                    EditEvent?.Invoke(this, EventArgs.Empty);
                    tabControl1.TabPages.Remove(tpFuncionarioList);
                    tabControl1.TabPages.Add(tpFuncionarioDetalhes);
                    tpFuncionarioDetalhes.Text = "Atualizar Funcionario";

                    cbSituacao.Enabled = true;

                    txtData.Visible = true;                

                    lblTxtData.Visible = true;
                }
                else
                {
                    MessageBox.Show("Não há registros...");
                }

            };
            btnSalvar.Click  += delegate 
            { 
                SaveEvent?.Invoke(this, EventArgs.Empty);
                if (IsSuccessful)
                {
                    tabControl1.TabPages.Remove(tpFuncionarioDetalhes);
                    tabControl1.TabPages.Add(tpFuncionarioList);
                }

                MessageBox.Show(Message);
            };
            btnCancelar.Click += delegate
            { 
                CancelEvent?.Invoke(this, EventArgs.Empty);
                tabControl1.TabPages.Remove(tpFuncionarioDetalhes);
                tabControl1.TabPages.Add(tpFuncionarioList);

            };

            btnImprimir.Click += delegate
            {
                PrintEvent?.Invoke(this, EventArgs.Empty);
            };

            btnFechar.Click  += delegate { CloseForm(); };

        }
        public void CloseForm()
        {
            this.Close();
        }
        private void AjustarSituacao()
        {
            cbSituacao.Items.Add(new KeyValuePair<string, string>("Ativo", "A"));
            cbSituacao.Items.Add(new KeyValuePair<string, string>("Inativo", "I"));
            cbSituacao.DisplayMember = "Key";
            cbSituacao.ValueMember = "Value";
        }

        private DataTable GerarDadosRelatorioFuncionario()
        {
            var dt = new DataTable();
            dt.Columns.Add("id");
            dt.Columns.Add("nome");
            dt.Columns.Add("cpf");
            dt.Columns.Add("situacao");
            dt.Columns.Add("alteracao");

            foreach (DataGridViewRow item in dgvFuncionarios.Rows)
            {
                dt.Rows.Add(item.Cells["id"].Value.ToString(), item.Cells["nome"].Value.ToString(), item.Cells["cpf"].Value.ToString(), item.Cells["situacao"].Value.ToString(), item.Cells["data_alteracao"].Value.ToString());
            }

            return dt;
        }

        public event EventHandler SearchEvent;
        public event EventHandler AddNewEvent;
        public event EventHandler EditEvent;
        public event EventHandler SaveEvent;
        public event EventHandler CancelEvent;
        public event EventHandler PrintEvent;

        private static FuncionarioView instance;
        public void SetFuncionarioBidingSource(BindingSource funcionarioDt)
        {
            dgvFuncionarios.DataSource = funcionarioDt;
        }
        public static FuncionarioView GetInstance(Form parentContainer)
        {
            if(instance == null || instance.IsDisposed)
            {
                instance = new FuncionarioView();
                instance.MdiParent = parentContainer;
                instance.FormBorderStyle = FormBorderStyle.None;
                instance.Dock = DockStyle.Fill;
            }
            else
            {
                if(instance.WindowState == FormWindowState.Minimized)
                {
                    instance.WindowState = FormWindowState.Normal;
                }
                instance.BringToFront();
            }
            
            return instance;
        }


    }
}
