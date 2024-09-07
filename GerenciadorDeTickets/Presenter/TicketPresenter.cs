using GerenciadorDeTickets._Repositories;
using GerenciadorDeTickets.Models;
using GerenciadorDeTickets.Views;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace GerenciadorDeTickets.Presenter
{
    internal class TicketPresenter
    {
        private ITicketView view;
        private ITicketRepository repository;
        private BindingSource ticketBindingSource;
        private IEnumerable<TicketModel> ticketList;


        public  TicketPresenter(ITicketView view, ITicketRepository repository)
        {
            this.view = view;
            this.repository = repository;
            this.ticketBindingSource = new BindingSource();

            this.view.AddNewEvent += AddNewTicket;
            this.view.CancelEvent += CancelAction;
            this.view.SearchEvent += SearchTicket;
            this.view.EditEvent   += LoadSelectedTicketToEdit;
            this.view.SaveEvent   += SaveTicket;

            this.view.SetTicketBidingSource(ticketBindingSource);

            LoadTicketList();

            this.view.Show();
        }

        private void AddNewTicket(object sender, EventArgs e)
        {
            view.IsEdit = false;
        }

        private void CancelAction(object sender, EventArgs e)
        {
            CleanViewFields();
        }

        private void CleanViewFields()
        {
            view.TicketId = "0";
            view.TicketFuncionarioId = "";
            view.TicketFuncionarioNome = "";
            view.TicketQuantidade = 0;
            view.TicketSituacao = "";
            view.TicketDataEntrega = "";
        }

        private void LoadSelectedTicketToEdit(object sender, EventArgs e)
        {
            var ticket = (TicketModel)ticketBindingSource.Current;
            view.TicketId            = ticket.Id.ToString();
            view.TicketFuncionarioId = ticket.FuncionarioId.ToString();
            view.TicketQuantidade    = ticket.Quantidade;
            view.TicketSituacao      = ticket.Situacao.ToString();
            view.TicketDataEntrega   = ticket.DataEntrega.ToString("dd/MM/yyyy");

            view.IsEdit = true;
        }
        private void SaveTicket(object sender, EventArgs e)
        {
            var model = new TicketModel();

            model.Id = Convert.ToInt32(view.TicketId);
            model.FuncionarioId = Convert.ToInt32(view.TicketFuncionarioId);
            model.Quantidade = Convert.ToInt32(view.TicketQuantidade);
            model.Situacao = Convert.ToChar(view.TicketSituacao);
            //model.DataEntrega = DateTime.Parse(view.TicketDataEntrega);

            try
            {
                new Common.ModelDataValidation().Validate(model);

                if (view.IsEdit)
                {
                    repository.Edit(model);
                    view.Message = "Ticket atualizado com sucesso!";
                }
                else
                {
                    repository.Add(model);
                    view.Message = "Ticket adicionado com sucesso!";
                }
                view.IsSuccessful = true;
                LoadTicketList();
                CleanViewFields();
            }
            catch (Exception ex) 
            {
                view.IsSuccessful = false;
                view.Message = "Erro ao tentar salvar: " + ex.Message;
            }

        }
        private void SearchTicket(object sender, EventArgs e)
        {
            bool emptyValue = string.IsNullOrWhiteSpace(this.view.SearchValue);
            if (emptyValue == false) 
            {
                ticketList = repository.GetByValue(this.view.SearchValue);
            }
            else
            {
                ticketList = repository.GetAll();
            }
        }
        private void LoadTicketList()
        {
            ticketList = repository.GetAll();
            ticketBindingSource.DataSource = ticketList;

        }
    }
}
