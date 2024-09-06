using GerenciadorDeTickets.Banco;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

using MySql.Data.MySqlClient;
using GerenciadorDeTickets.Views;

namespace GerenciadorDeTickets
{
    public partial class PrincipalView : Form, IPrincipalView
    {

        public PrincipalView()
        {
            InitializeComponent();
            AssociateAndRaiseViewEvents();

        }

        private void AssociateAndRaiseViewEvents()
        {
            miFuncionarios.Click += delegate { ShowFuncionarioView?.Invoke(this, EventArgs.Empty); };

        }
        public event EventHandler ShowFuncionarioView;
        public event EventHandler ShowTicketView;

    }
}
