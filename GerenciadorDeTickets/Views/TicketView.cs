using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace GerenciadorDeTickets.Views
{
    public partial class TicketView : Form, ITicketView
    {
        public TicketView()
        {
            InitializeComponent();
            AssociateAndRaiseViewEvents();
            AjustarSituacao();

            tabControl1.TabPages.Remove(tpTicketDetalhes);
        }

        private void AssociateAndRaiseViewEvents()
        {
            btnBuscar.Click += delegate
            {
                SearchEvent?.Invoke(this, EventArgs.Empty);
            };

            btnNovo.Click += delegate
            {
                AddNewEvent?.Invoke(this, EventArgs.Empty);
                tabControl1.TabPages.Remove(tpTicketList);
                tabControl1.TabPages.Add(tpTicketDetalhes);
                tpTicketDetalhes.Text = "Adicionar Ticket";

                cbSituacao.SelectedIndex = 0;
                cbSituacao.Enabled = false;

                dtDataEntrega.Visible = false;

                lblTxtData.Visible = false;
            };

            btnAlterar.Click += delegate
            {
                if (dgvTickets.Rows.Count > 0)
                {
                    EditEvent?.Invoke(this, EventArgs.Empty);
                    tabControl1.TabPages.Remove(tpTicketList);
                    tabControl1.TabPages.Add(tpTicketDetalhes);
                    tpTicketDetalhes.Text = "Atualizar Ticket";

                    cbSituacao.Enabled = true;

                    dtDataEntrega.Visible = true;

                    lblTxtData.Visible = true;
                }
                else
                {
                    MessageBox.Show("Não há registros...");
                }
            };

            btnSalvar.Click += delegate
            {
                SaveEvent?.Invoke(this, EventArgs.Empty);

                if (IsSuccessful)
                {
                    tabControl1.TabPages.Remove(tpTicketDetalhes);
                    tabControl1.TabPages.Add(tpTicketList);
                }
                MessageBox.Show(Message);
            };

            btnCancelar.Click += delegate
            {
                CancelEvent?.Invoke(this, EventArgs.Empty);

                tabControl1.TabPages.Remove(tpTicketDetalhes);
                tabControl1.TabPages.Add(tpTicketList);
            };

            txtFuncionarioId.Leave += delegate { FuncionarioId_Leave?.Invoke(this, EventArgs.Empty); };

            btnFechar.Click += delegate { CloseForm(); };
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

        public string TicketId 
        {
            get { return lblId.Text; }
            set { lblId.Text = value; }
        }
        public string TicketFuncionarioId 
        {
            get { return txtFuncionarioId.Text; }
            set { txtFuncionarioId.Text = value; }
        }

        public string TicketFuncionarioNome
        {
            get { return txtFuncionairoNome.Text; }
            set { txtFuncionairoNome.Text = value; }
        }
        public int TicketQuantidade
        {
            get { return (int)nupQuantidade.Value; }
            set { nupQuantidade.Value = value; }
        }
        public string TicketSituacao 
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
        public DateTime TicketDataEntrega
        {
            get { return dtDataEntrega.Value; }
            set { dtDataEntrega.Value = value; }
        }
        public string SearchValue
        {
            get { return txtBuscar.Text; }
            set { txtBuscar.Text = value; }
        }
        public bool IsEdit { get; set; }
        public bool IsSuccessful { get; set; }
        public string Message { get; set; }

        public event EventHandler SearchEvent;
        public event EventHandler AddNewEvent;
        public event EventHandler EditEvent;
        public event EventHandler SaveEvent;
        public event EventHandler CancelEvent;
        public event EventHandler FuncionarioId_Leave;

        public void SetTicketBidingSource(BindingSource ticketList)
        {
            dgvTickets.DataSource = ticketList;
        }

        private static TicketView instance;

        public static TicketView GetInstance(Form parentContainer)
        {
            if (instance == null || instance.IsDisposed)
            {
                instance = new TicketView();
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

    }
}
