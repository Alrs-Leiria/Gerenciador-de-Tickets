using GerenciadorDeTickets.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GerenciadorDeTickets._Repositories
{
    internal interface ITicketRepository
    {
        void Add(TicketModel ticketModel);
        void Edit(TicketModel ticketModel);
        IEnumerable<TicketModel> GetAll();
        IEnumerable<TicketModel> GetByValue(string value);
    }
}
