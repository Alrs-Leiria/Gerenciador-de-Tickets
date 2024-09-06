using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using MySql.Data.MySqlClient;

namespace GerenciadorDeTickets.Models
{
    internal class TicketModel
    {
        private int id {  get; set; }
        private FuncionarioModel funcionario {  get; set; }
        private int quantidade { get; set; }
        private char situacao { get; set; }

        public TicketModel(int id, FuncionarioModel funcionario, int quantidade, char situacao)
        {
            this.id = id;
            this.funcionario = funcionario;
            this.quantidade = quantidade;
            this.situacao = situacao;
        }
    }
}
