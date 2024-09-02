using GerenciadorDeTickets.Banco;
using MySql.Data.MySqlClient;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace GerenciadorDeTickets.Models
{
    internal class Funcionario
    {
        private int id { get; set; }
        private string nome { get; set; }
        private string cpf { get; set; }
        private char situacao { get; set; }
        private DateTime dataAlteracao { get; set; }

        public Funcionario()
        {

        }

        public static DataTable GetDataTableFuncionarios()
        {
            var dt = new DataTable();

            var sql = "SELECT * FROM funcionarios";


            using (var da = new MySqlDataAdapter(sql, Conexao.AbrirConexao()))
            {
                da.Fill(dt);
                Conexao.FecharConexao();
            }              
            return dt;
        }
    }
}
