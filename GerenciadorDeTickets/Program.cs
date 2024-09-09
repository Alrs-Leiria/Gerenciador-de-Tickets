using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.Windows.Forms;
using GerenciadorDeTickets.Models;
using GerenciadorDeTickets.Presenter;
using GerenciadorDeTickets._Repositories;
using GerenciadorDeTickets.Views;
using MySql.Data.MySqlClient;



namespace GerenciadorDeTickets
{
    internal static class Program
    {
        /// <summary>
        /// Ponto de entrada principal para o aplicativo.
        /// </summary>
        [STAThread]
        static void Main()
        {
            Application.EnableVisualStyles();
            Application.SetCompatibleTextRenderingDefault(false);

            string sqlConnectionString = "Server=localhost;user=root;password=1234;database=gerenciador;";
            IPrincipalView view = new PrincipalView();

            new PrincipalPresenter(view, sqlConnectionString);

            Application.Run((Form) view);
        }
    }
}
