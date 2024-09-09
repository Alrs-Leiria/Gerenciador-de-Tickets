using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using MySql.Data.MySqlClient;

namespace GerenciadorDeTickets.Models
{
    public class TicketModel
    {
        [Key]
        [DatabaseGenerated(DatabaseGeneratedOption.Identity)]
        public int Id { get; set; }

        [Required(ErrorMessage = "Funcionário é obrigatório!")]
        [Range(1, int.MaxValue, ErrorMessage = "Codigo do funcionario deve ser maior que zero!.")]
        public int FuncionarioId { get; set; }

        [Required(ErrorMessage = "A quantidade de tickets é obrigatória!")]
        [Range(1, int.MaxValue, ErrorMessage = "A quantidade de tickets deve ser maior que zero!.")]
        public int Quantidade { get; set; }

        [Required(ErrorMessage = "Situação é obrigatória!")]
        [RegularExpression(@"^[AI]$", ErrorMessage = "A Situação deve ser 'A' para Ativo ou 'I' para Inativo!")]
        public char Situacao { get; set; }

        [DatabaseGenerated(DatabaseGeneratedOption.Computed)]
        public DateTime DataEntrega { get; set; }
    }
}
