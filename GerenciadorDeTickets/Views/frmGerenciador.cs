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
    public partial class FrmGerenciador : Form
    {
        public FrmGerenciador()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void funcionariosToolStripMenuItem_Click(object sender, EventArgs e)
        {
            FrmFuncionarioListagem FrmFuncionario = new FrmFuncionarioListagem();
            FrmFuncionario.ShowDialog();
        }
    }
}
