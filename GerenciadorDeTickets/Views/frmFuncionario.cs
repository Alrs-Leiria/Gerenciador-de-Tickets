using GerenciadorDeTickets.Models;
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
    public partial class frmFuncionario : Form
    {
        DataTable dt = new DataTable();
        public frmFuncionario()
        {
            InitializeComponent();
            inicializar();
        }

        private void inicializar()
        {
            dt = Funcionario.GetDataTableFuncionarios();
            dgvFuncionarios.DataSource = dt;
            ConfigurarGridViewFuncrionarios();
        }

        private void ConfigurarGridViewFuncrionarios()
        {
            dgvFuncionarios.ColumnHeadersDefaultCellStyle.Font = new Font("Arial", 9, FontStyle.Bold);   
            dgvFuncionarios.DefaultCellStyle.Font = new Font("Arial", 8);
            dgvFuncionarios.RowHeadersWidth = 25;

            dgvFuncionarios.Columns["id"].HeaderText = "ID";
            dgvFuncionarios.Columns["id"].Visible = false;

            dgvFuncionarios.Columns["Nome"].HeaderText = "NOME";
            dgvFuncionarios.Columns["Nome"].Width = 150;
            dgvFuncionarios.Columns["Nome"].HeaderCell.Style.Alignment = DataGridViewContentAlignment.MiddleCenter;
            dgvFuncionarios.Columns["Nome"].DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleCenter;

            dgvFuncionarios.Columns["CPF"].HeaderText = "CPF";
            dgvFuncionarios.Columns["CPF"].Width = 120;
            dgvFuncionarios.Columns["CPF"].HeaderCell.Style.Alignment = DataGridViewContentAlignment.MiddleCenter;
            dgvFuncionarios.Columns["CPF"].DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleCenter;

            dgvFuncionarios.Columns["Situacao"].HeaderText = "SITUAÇÃO";
            dgvFuncionarios.Columns["Situacao"].Width = 100;
            dgvFuncionarios.Columns["Situacao"].HeaderCell.Style.Alignment = DataGridViewContentAlignment.MiddleCenter;
            dgvFuncionarios.Columns["Situacao"].DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleCenter;

            dgvFuncionarios.Columns["DataAlteracao"].HeaderText = "DATA ALTERAÇÃO";
            dgvFuncionarios.Columns["DataAlteracao"].Width = 150;
            dgvFuncionarios.Columns["DataAlteracao"].HeaderCell.Style.Alignment = DataGridViewContentAlignment.MiddleCenter;
            dgvFuncionarios.Columns["DataAlteracao"].DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleCenter;

            dgvFuncionarios.Sort(dgvFuncionarios.Columns["Nome"], ListSortDirection.Ascending);

        }
    }
}
