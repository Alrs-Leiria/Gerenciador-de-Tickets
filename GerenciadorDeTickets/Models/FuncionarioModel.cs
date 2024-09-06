using GerenciadorDeTickets.Banco;
using MySql.Data.MySqlClient;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;
using System.ComponentModel.DataAnnotations;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace GerenciadorDeTickets.Models
{
    public class FuncionarioModel
    {
        private int id;
        private string nome;
        private string cpf;
        private char situcao;
        private DateTime dataAlteracao;


        public int Id { get; set; }

        [Required(ErrorMessage = "Nome é obrigatório!")]
        [StringLength(255, ErrorMessage = "O nome deve ter no máximo 255 caracteres.")]
        public string Nome { get; set; }

        [Required(ErrorMessage = "CPF é obrigatório!")]
        [RegularExpression(@"^\d{11}$", ErrorMessage = "O CPF deve conter exatamente 11 dígitos numéricos.")]
        public string Cpf { get; set; }

        [Required(ErrorMessage = "Situação é obrigatória!")]
        [RegularExpression(@"^[AI]$", ErrorMessage = "A Situação deve ser 'A' para Ativo ou 'I' para Inativo.")]
        public char Situacao { get; set; }

        [DatabaseGenerated(DatabaseGeneratedOption.Computed)]
        public DateTime DataAlteracao { get; set; }

        //public void AdicionarFuncionario()
        //{
        //    var sql = "INSERT INTO " +
        //        "funcionarios(nome, cpf, situacao) " +
        //        "VALUES " +
        //        "(@nome, @cpf, @situacao)";

        //    try
        //    {
        //        using (var cmd = new MySqlCommand(sql, Conexao.AbrirConexao()))
        //        {
        //            cmd.Parameters.AddWithValue("@nome", this.Nome);
        //            cmd.Parameters.AddWithValue("@cpf", this.Cpf);
        //            cmd.Parameters.AddWithValue("@situacao", this.Situacao);         

        //            cmd.ExecuteNonQuery();
        //        }
        //    }
        //    catch (Exception ex)
        //    {
        //        MessageBox.Show("Erro ao tentar adicionar o cadastro do funcionario: " + ex.Message);
        //    }
        //    finally
        //    {
        //        Conexao.FecharConexao();
        //    }
        //}
        //public void AtualizarFuncionario()
        //{
        //    var sql = "UPDATE funcionarios SET " +
        //        "nome=@nome, " +
        //        "cpf=@cpf, " +
        //        "situacao=@situacao " +
        //        "WHERE id=@id ";

        //    try
        //    {
        //        using (var cmd = new MySqlCommand(sql, Conexao.AbrirConexao()))
        //        {
        //            cmd.Parameters.AddWithValue("@nome", this.Nome);
        //            cmd.Parameters.AddWithValue("@cpf", this.Cpf);
        //            cmd.Parameters.AddWithValue("@situacao", this.Situacao);
        //            cmd.Parameters.AddWithValue("@id", this.Id);                  

        //            cmd.ExecuteNonQuery();
        //        }
        //    }
        //    catch (Exception ex)
        //    {
        //        MessageBox.Show("Erro ao tentar executar a atualização do cadastro do funcionario: " + ex.Message);
        //    }
        //    finally
        //    {
        //        Conexao.FecharConexao();
        //    }
        //}
        //public static DataTable GetDataTableFuncionarios(string buscar = "")
        //{
        //    var dt = new DataTable();

        //    var sql = "SELECT * FROM funcionarios ";

        //    if (buscar != "")
        //    {
        //        sql += "WHERE nome LIKE '%" + buscar + "%' OR id LIKE '%" + buscar + "%'";
        //    }
        //    try
        //    {
        //        using (var da = new MySqlDataAdapter(sql, Conexao.AbrirConexao()))
        //        {
        //            da.Fill(dt);
        //        }
        //    }
        //    catch (Exception ex)
        //    {
        //        MessageBox.Show("Erro ao tentar gerar os dados para o data table: " + ex.Message);
        //    }


        //    return dt;
        //}
        //public void GetFuncionario(int id)
        //{
        //    var sql = "SELECT * FROM funcionarios WHERE id = " + id;

        //    try
        //    {
        //        using (var cmd = new MySqlCommand(sql, Conexao.AbrirConexao()))
        //        {
        //            using (var dr = cmd.ExecuteReader())
        //            {
        //                if (dr.HasRows)
        //                {
        //                    if (dr.Read())
        //                    {
        //                        this.Id = Convert.ToInt32(dr["id"]);
        //                        this.Nome = dr["nome"].ToString();
        //                        this.Cpf = dr["cpf"].ToString();
        //                        //this.Situacao = (char)dr["situacao"];
        //                        this.DataAlteracao = (DateTime)dr["data_alteracao"];
        //                    }
        //                }
        //            }
        //        }
        //    }
        //    catch (Exception ex)
        //    {
        //        MessageBox.Show("Erro ao tentar buscar funcionario: " + ex.Message);
        //    }finally
        //    {
        //        Conexao.FecharConexao();
        //    }

        //}
    }
}
