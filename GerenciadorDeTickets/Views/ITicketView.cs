using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace GerenciadorDeTickets.Views
{
    internal interface ITicketView
    {
        string TicketId { get; set; }
        string TicketFuncionarioId { get; set; }
        string TicketFuncionarioNome {  get; set; }
        int TicketQuantidade { get; set; }
        string TicketSituacao { get; set; }
        DateTime TicketDataEntrega { get; set; }

        string SearchValue { get; set; }
        bool IsEdit { get; set; }
        bool IsSuccessful { get; set; }
        string Message { get; set; }

        event EventHandler SearchEvent;
        event EventHandler AddNewEvent;
        event EventHandler EditEvent;
        event EventHandler SaveEvent;
        event EventHandler CancelEvent;
        event EventHandler FuncionarioId_Leave;

        void CloseForm();
        void SetTicketBidingSource(BindingSource ticketList);
        void Show();
    }
}
