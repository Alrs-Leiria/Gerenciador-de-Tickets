using System;
using System.Collections.Generic;
using System.Data.Common;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

using MySql.Data.MySqlClient;
namespace GerenciadorDeTickets.Banco
{
    static class Conexao
    {
        private const string server = "localhost";
        private const string databse = "gerenciador";
        private const string username = "root";
        private const string password = "1234";

        private static string data{  get; set; }
        private static MySqlConnection connection;
        
        public static MySqlConnection AbrirConexao()
        {
            data = $"Server={server};username={username};password={password};database={databse};";

            try
            {
                connection = new MySqlConnection(data);
                if(connection.State == System.Data.ConnectionState.Closed)
                {
                    connection.Open();
                }                            
            }
            catch (Exception ex)
            {
                Console.WriteLine("Erro ao abrir a conexão: " + ex.Message);
            }

            //MessageBox.Show("Conexao realizada com sucesso!");
            return connection;
        }
        public static void FecharConexao()
        {
            try
            {

                connection.Close();

            }
            catch (Exception ex)
            {
                Console.WriteLine("Erro ao fechar a conexão: " + ex.Message);
            }
        }

        public static MySqlConnection GetConnection()
        {
            return connection;
        }
    }
}
