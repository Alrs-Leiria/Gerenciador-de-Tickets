using GerenciadorDeTickets.Models;
using MySql.Data.MySqlClient;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace GerenciadorDeTickets._Repositories
{
    internal class TicketRepository : BaseRepository, ITicketRepository
    {
        public TicketRepository(string connection) 
        {
            connectionPath = connection;
        }
        public void Add(TicketModel ticketModel)
        {
            var sql = @"INSERT INTO tickets(funcionario_id, quantidade, situacao) 
                        VALUES (@funcionario_id, @quantidade, @situacao)";

            using (MySqlConnection connection = new MySqlConnection(connectionPath))
            {
                connection.Open();

                using (var command = new MySqlCommand(sql, connection))
                {
                    command.Parameters.AddWithValue("@funcionario_id", ticketModel.FuncionarioId);
                    command.Parameters.AddWithValue("@quantidade",     ticketModel.Quantidade);
                    command.Parameters.AddWithValue("@situacao",       ticketModel.Situacao);

                    command.ExecuteNonQuery();
                }
            }
        }

        public void Edit(TicketModel ticketModel)
        {
            var sql = @"UPDATE tickets SET
                        funcionario_id=@funcionario_id,
                        quantidade=@quantidade,
                        situacao=@situacao,
                        data_entrega=@data
                        WHERE id=@id";

            using (MySqlConnection connection = new MySqlConnection(connectionPath))
            {
                connection.Open();

                using (var command = new MySqlCommand(sql, connection))
                {
                    command.Parameters.AddWithValue("@funcionario_id", ticketModel.FuncionarioId);
                    command.Parameters.AddWithValue("@quantidade",     ticketModel.Quantidade);
                    command.Parameters.AddWithValue("@situacao",       ticketModel.Situacao);
                    command.Parameters.AddWithValue("@data",           ticketModel.DataEntrega);
                    command.Parameters.AddWithValue("@id",             ticketModel.Id);

                    command.ExecuteNonQuery();
                }
            }
        }

        public IEnumerable<TicketModel> GetAll()
        {
            var ticketsList = new List<TicketModel>();
            var sql = @"SELECT * FROM tickets  ORDER BY id DESC";
            using (MySqlConnection connection = new MySqlConnection(connectionPath))
            {
                connection.Open();

                using (var command = new MySqlCommand(sql, connection))
                {

                    using (MySqlDataReader reader = command.ExecuteReader())
                    {
                        while (reader.Read())
                        {
                            var ticketModel = new TicketModel();

                            try
                            {
                                ticketModel.Id            = reader.GetInt32("id");
                                ticketModel.FuncionarioId = reader.GetInt32("funcionario_id");
                                ticketModel.Quantidade    = reader.GetInt32("quantidade");
                                ticketModel.Situacao      = reader.GetChar("situacao");
                                ticketModel.DataEntrega   = reader.GetDateTime("data_entrega");
                            }
                            catch (Exception ex)
                            {
                                MessageBox.Show("Erro: " + ex.Message);
                            }
                            ticketsList.Add(ticketModel);
                        }
                    }
                }
            }
            return ticketsList;
        }

        public IEnumerable<TicketModel> GetByValue(string value)
        {
            var ticketsList = new List<TicketModel>();

            int ticketId = int.TryParse(value, out _) ? Convert.ToInt32(value) : 0;
            string funcionarioNome = value;

            var sql = @"SELECT t.*, f.nome FROM tickets t
                        INNER JOIN funcionarios f ON(t.funcionario_id = f.id)
                        WHERE t.id=@id OR f.nome LIKE @nome ORDER BY id DESC";
            using (MySqlConnection connection = new MySqlConnection(connectionPath))
            {
                connection.Open();

                using (var command = new MySqlCommand(sql, connection))
                {
                    command.Parameters.AddWithValue("@id", ticketId);
                    command.Parameters.AddWithValue("@nome", "%" + funcionarioNome + "%");

                    using (MySqlDataReader reader = command.ExecuteReader())
                    {
                        while (reader.Read())
                        {
                            var ticketModel = new TicketModel();

                            try
                            {
                                ticketModel.Id            = reader.GetInt32("id");
                                ticketModel.FuncionarioId = reader.GetInt32("funcionario_id");
                                ticketModel.Quantidade    = reader.GetInt32("quantidade");
                                ticketModel.Situacao      = reader.GetChar("situacao");
                                ticketModel.DataEntrega   = reader.GetDateTime("data_entrega");
                            }
                            catch (Exception ex)
                            {
                                MessageBox.Show("Erro: " + ex.Message);
                            }
                            ticketsList.Add(ticketModel);
                        }
                    }
                }
            }
            return ticketsList;
        }
    }
}
