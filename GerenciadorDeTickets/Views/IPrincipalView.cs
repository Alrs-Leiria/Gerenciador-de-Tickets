using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GerenciadorDeTickets.Views
{
    public interface IPrincipalView
    {
        event EventHandler ShowFuncionarioView;
        event EventHandler ShowTicketView;
        event EventHandler ShowRelatorioView;

    }
}
