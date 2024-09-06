using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.SqlClient;
using System.Data;
using System.Drawing;
using GerenciadorDeTickets.Models;
using MySql.Data.MySqlClient;
using GerenciadorDeTickets.Banco;
using Google.Protobuf.WellKnownTypes;
using System.Windows.Forms;

namespace GerenciadorDeTickets._Repositories
{
    public class FuncionarioRepository : BaseRepository, IFuncionarioRepository 
    {
        public FuncionarioRepository(string connection) 
        {
            connectionPath = connection;
        }

        void IFuncionarioRepository.Add(FuncionarioModel funcionarioModel)
        {
            var sql = @"INSERT INTO funcionarios(nome, cpf, situacao) 
                        VALUES (@nome, @cpf, @situacao)";

            using (MySqlConnection connection = new MySqlConnection(connectionPath))
            {
                connection.Open();

                using (var command = new MySqlCommand(sql, connection))
                {
                    command.Parameters.AddWithValue("@nome", funcionarioModel.Nome);
                    command.Parameters.AddWithValue("@cpf", funcionarioModel.Cpf);
                    command.Parameters.AddWithValue("@situacao", funcionarioModel.Situacao);

                    command.ExecuteNonQuery();
                }
            }
        }

        void IFuncionarioRepository.Edit(FuncionarioModel funcionarioModel)
        {
            var sql = @"UPDATE funcionarios SET
                        nome=@nome,
                        cpf=@cpf,
                        situacao=@situacao 
                        WHERE id=@id";

            using (MySqlConnection connection = new MySqlConnection(connectionPath))
            {
                connection.Open();

                using (var command = new MySqlCommand(sql, connection))
                {
                    command.Parameters.AddWithValue("@nome", funcionarioModel.Nome);
                    command.Parameters.AddWithValue("@cpf", funcionarioModel.Cpf);
                    command.Parameters.AddWithValue("@situacao", funcionarioModel.Situacao);
                    command.Parameters.AddWithValue("@id", funcionarioModel.Id);

                    command.ExecuteNonQuery();
                }
            }
        }

        IEnumerable<FuncionarioModel> IFuncionarioRepository.GetAll()
        {
            var funcionarioList = new List<FuncionarioModel>();
            var sql = @"SELECT * FROM funcionarios  ORDER BY id desc";
            using (MySqlConnection connection = new MySqlConnection(connectionPath))
            {
                connection.Open();

                using (var command = new MySqlCommand(sql, connection))
                {

                    using (MySqlDataReader reader = command.ExecuteReader())
                    {
                        while (reader.Read())
                        {
                            var funcionarioModel = new FuncionarioModel();

                            try
                            {
                                funcionarioModel.Id = reader.GetInt32("id");
                                funcionarioModel.Nome = reader.GetString("nome");
                                funcionarioModel.Cpf = reader.GetString("cpf");
                                funcionarioModel.Situacao = reader.GetChar("situacao");
                                funcionarioModel.DataAlteracao = reader.GetDateTime("data_alteracao");
                            }
                            catch (Exception ex)
                            {
                                MessageBox.Show("Erro: " + ex.Message);
                            }


                            funcionarioList.Add(funcionarioModel);
                        }
                    }

                }
            }

            return funcionarioList;
        }

        IEnumerable<FuncionarioModel> IFuncionarioRepository.GetByValue(string value)
        {
            var funcionarioList = new List<FuncionarioModel>();
            int funcionarioId = int.TryParse(value, out _) ? Convert.ToInt32(value) : 0;
            string funcionarioNome = value;

            var sql = @"SELECT * FROM funcionarios 
                                        WHERE id=@id OR nome LIKE @nome
                                        ORDER BY id desc";
            using (MySqlConnection connection = new MySqlConnection(connectionPath))
            {
                connection.Open();

                using (var command = new MySqlCommand(sql, connection))
                {
                    command.Parameters.AddWithValue("@id", funcionarioId);
                    command.Parameters.AddWithValue("nome", "%" + funcionarioNome + "%");

                    using (MySqlDataReader reader = command.ExecuteReader())
                    {
                        while (reader.Read())
                        {
                            FuncionarioModel funcionarioModel = new FuncionarioModel();

                            funcionarioModel.Id = reader.GetInt32("id");
                            funcionarioModel.Nome = reader.GetString("nome");
                            funcionarioModel.Cpf = reader.GetString("cpf");
                            funcionarioModel.Situacao = reader.GetChar("situacao");
                            funcionarioModel.DataAlteracao = reader.GetDateTime("data_alteracao");

                            funcionarioList.Add(funcionarioModel);
                        }
                    }

                }
            }
            return funcionarioList;
        }
    }
}
