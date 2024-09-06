using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace GerenciadorDeTickets.Views
{
    internal interface IFuncionarioView
    {
        string FuncionarioId { get; set; }
        string FuncionarioNome { get; set; }
        string FuncionarioCpf { get; set; }
        string FuncionarioSituacao { get; set; }
        string FuncionarioDataAlteracao { get; set; }

        string SearchValue  { get; set; }
        bool IsEdit     { get; set; }
        bool IsSuccessful { get; set; }
        string Message { get; set; }

        event EventHandler SearchEvent;
        event EventHandler AddNewEvent;
        event EventHandler EditEvent;
        event EventHandler SaveEvent;
        event EventHandler CancelEvent;

        void SetFuncionarioBidingSource(BindingSource funcionarioList);
        void Show();
    }
}
