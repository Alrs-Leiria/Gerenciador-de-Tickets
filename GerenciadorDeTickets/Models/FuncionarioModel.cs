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
    public class FuncionarioModel
    {
        //private int id;
        //private string nome;
        //private string cpf;
        //private char situcao;
        //private DateTime dataAlteracao;

        [Key]
        [DatabaseGenerated(DatabaseGeneratedOption.Identity)]
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

    }
}
