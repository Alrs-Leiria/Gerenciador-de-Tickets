using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using GerenciadorDeTickets.Models;
using GerenciadorDeTickets._Repositories;
using GerenciadorDeTickets.Views;
using System.Windows.Forms;


namespace GerenciadorDeTickets.Presenter
{
    public class PrincipalPresenter
    {
        private IPrincipalView principalView;
        private readonly string sqlConnectionString;

        IFuncionarioView funcionarioView;
        ITicketView ticketView;
        IRelatorioView relatorioView;

        public PrincipalPresenter(IPrincipalView principalView, string sqlConnectionString)
        {
            this.principalView = principalView;
            this.sqlConnectionString = sqlConnectionString;
            this.principalView.ShowFuncionarioView += ShowFuncionarioView;
            this.principalView.ShowTicketView += ShowTicketView; 
            this.principalView.ShowRelatorioView += ShowRelatorioView;
        }

        private void ShowFuncionarioView(object sender, EventArgs e)
        {
            //IFuncionarioView view = FuncionarioView.GetInstance((PrincipalView) principalView);
            funcionarioView = FuncionarioView.GetInstance((PrincipalView)principalView);
            IFuncionarioRepository repository = new FuncionarioRepository(sqlConnectionString);

            new FuncionarioPresenter(funcionarioView, repository);

            if (ticketView != null)
            {
                ticketView.CloseForm();
            }

            if (relatorioView != null)
            {
                relatorioView.CloseForm();
            }

        }

        private void ShowTicketView(object sender, EventArgs e)
        {
            //ITicketView view = TicketView.GetInstance((PrincipalView) principalView);
            ticketView = TicketView.GetInstance((PrincipalView)principalView);
            ITicketRepository repository = new TicketRepository(sqlConnectionString);
            IFuncionarioRepository funcionarioRepository = new FuncionarioRepository(sqlConnectionString);

            new TicketPresenter(ticketView, repository, funcionarioRepository);

            if (funcionarioView != null)
            {
                funcionarioView.CloseForm();
            }

            if (relatorioView != null)
            {
                relatorioView.CloseForm();
            }
        }
        private void ShowRelatorioView(object sender, EventArgs e)
        {
            //IRelatorioView view = RelatorioView.GetInstance((PrincipalView)principalView);
            relatorioView = RelatorioView.GetInstance((PrincipalView)principalView);
            IFuncionarioRepository funcionarioRepository = new FuncionarioRepository(sqlConnectionString);

            new RelatorioPresenter(relatorioView, funcionarioRepository);

            if (funcionarioView != null)
            {
                funcionarioView.CloseForm();
            }

            if(ticketView != null)
            {
                ticketView.CloseForm();
            }
        }

        private void CloseOtherForms(params Form[] formsToClose)
        {
            foreach (var form in formsToClose)
            {
                if (form != null && !form.IsDisposed)
                {
                    form.Close();
                }
            }
        }
    }
}
