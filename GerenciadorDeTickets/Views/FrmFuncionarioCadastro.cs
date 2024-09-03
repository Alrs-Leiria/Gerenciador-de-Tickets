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
    public partial class FrmFuncionarioCadastro : Form
    {
        private int id;

        Funcionario funcionario = new Funcionario();

        public FrmFuncionarioCadastro()
        {
            InitializeComponent();
        }
        public FrmFuncionarioCadastro(int id)
        {
            InitializeComponent();
            this.id = id;

            if (this.id > 0)
            {
                funcionario.GetFuncionario(this.id);

                lblId.Text = funcionario.Id.ToString();
                txtNome.Text = funcionario.Nome.ToString();
                txtCpf.Text = funcionario.Cpf.ToString();
                lblData.Text = funcionario.DataAlteracao.ToString();

            }

            
        }

        private void btnSalvar_Click(object sender, EventArgs e)
        {
            if(ValidarForms())
            {

                funcionario.Nome = txtNome.Text;
                funcionario.Cpf = txtCpf.Text;
                funcionario.Situacao = 'A';
                if (funcionario.Id > 0)
                {
                    funcionario.Id = Convert.ToInt32(lblId.Text);
                    funcionario.AtualizarFuncionario();
                }
                else
                {
                    funcionario.AdicionarFuncionario();
                }

                this.Close();
            }

            
        }

        public Boolean ValidarForms()
        {
            return true;
        }
    }
}
