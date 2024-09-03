using GerenciadorDeTickets.Models;
using GerenciadorDeTickets.Relatorios.WinForms;
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
    public partial class FrmFuncionarioListagem : Form
    {
        DataTable dt = new DataTable();
        public FrmFuncionarioListagem()
        {
            InitializeComponent();
            Inicializar();
        }

        private void Inicializar()
        {
            dt = Funcionario.GetDataTableFuncionarios();
            dgvFuncionarios.DataSource = dt;
            ConfigurarGridViewFuncionarios();
        }

        private void ConfigurarGridViewFuncionarios()
        {
            dgvFuncionarios.ColumnHeadersDefaultCellStyle.Font = new Font("Arial", 9, FontStyle.Bold);   
            dgvFuncionarios.DefaultCellStyle.Font = new Font("Arial", 8);
            dgvFuncionarios.RowHeadersWidth = 25;

            dgvFuncionarios.Columns["id"].HeaderText = "ID";
            dgvFuncionarios.Columns["id"].Width = 50;
            dgvFuncionarios.Columns["id"].HeaderCell.Style.Alignment = DataGridViewContentAlignment.MiddleCenter;
            dgvFuncionarios.Columns["id"].DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleCenter;

            dgvFuncionarios.Columns["nome"].HeaderText = "NOME";
            dgvFuncionarios.Columns["nome"].Width = 150;
            dgvFuncionarios.Columns["nome"].HeaderCell.Style.Alignment = DataGridViewContentAlignment.MiddleCenter;
            dgvFuncionarios.Columns["nome"].DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleCenter;

            dgvFuncionarios.Columns["cpf"].HeaderText = "CPF";
            dgvFuncionarios.Columns["cpf"].Width = 120;
            dgvFuncionarios.Columns["cpf"].HeaderCell.Style.Alignment = DataGridViewContentAlignment.MiddleCenter;
            dgvFuncionarios.Columns["cpf"].DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleCenter;

            dgvFuncionarios.Columns["situacao"].HeaderText = "SITUAÇÃO";
            dgvFuncionarios.Columns["situacao"].Width = 100;
            dgvFuncionarios.Columns["situacao"].HeaderCell.Style.Alignment = DataGridViewContentAlignment.MiddleCenter;
            dgvFuncionarios.Columns["situacao"].DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleCenter;

            dgvFuncionarios.Columns["data_alteracao"].HeaderText = "DATA ALTERAÇÃO";
            dgvFuncionarios.Columns["data_alteracao"].Width = 150;
            dgvFuncionarios.Columns["data_alteracao"].HeaderCell.Style.Alignment = DataGridViewContentAlignment.MiddleCenter;
            dgvFuncionarios.Columns["data_alteracao"].DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleCenter;

            dgvFuncionarios.Sort(dgvFuncionarios.Columns["Nome"], ListSortDirection.Ascending);

        }

        private void btnAlterar_Click(object sender, EventArgs e)
        {
            var id = Convert.ToInt32(dgvFuncionarios.Rows[dgvFuncionarios.CurrentCell.RowIndex].Cells["id"].Value);

            using (var frm = new FrmFuncionarioCadastro(id))
            {
                frm.ShowDialog();
                dgvFuncionarios.DataSource = Funcionario.GetDataTableFuncionarios();
                ConfigurarGridViewFuncionarios();
            }
        }

        private void btnNovo_Click(object sender, EventArgs e)
        {
            using (var frm = new FrmFuncionarioCadastro(0))
            {
                frm.ShowDialog();
                dgvFuncionarios.DataSource = Funcionario.GetDataTableFuncionarios();
                ConfigurarGridViewFuncionarios();
            }
        }

        private void btnBuscar_Click_1(object sender, EventArgs e)
        {
            dt = Funcionario.GetDataTableFuncionarios(txtBuscar.Text);
            dgvFuncionarios.DataSource = dt;
            ConfigurarGridViewFuncionarios();
        }

        private void btnImprimir_Click(object sender, EventArgs e)
        {
            var dt = GerarDadosRelatorioFuncionario();
            using(var frm = new FrmFuncionarioRelatorio(dt))
            {
                frm.ShowDialog();
            }
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
    }
}
