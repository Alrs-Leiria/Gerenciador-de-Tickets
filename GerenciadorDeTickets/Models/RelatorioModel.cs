using GerenciadorDeTickets.Banco;
using MySql.Data.MySqlClient;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace GerenciadorDeTickets.Models
{
    public class RelatorioModel
    {
           public int IdFuncionario {  get; set; }
           public string NomeFuncionario {  get; set; }  
           public string CpfFuncionario {  get; set; }
           public DateTime DataEntregaTicket {  get; set; }
           public int QuantidadeTicket { get; set; }
    }
}
