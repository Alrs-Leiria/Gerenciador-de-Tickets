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

        public PrincipalPresenter(IPrincipalView principalView, string sqlConnectionString)
        {
            this.principalView = principalView;
            this.sqlConnectionString = sqlConnectionString;
            this.principalView.ShowFuncionarioView += ShowFuncionarioView;
            this.principalView.ShowTicketView += ShowTicketView;    
        }

        private void ShowFuncionarioView(object sender, EventArgs e)
        {
            IFuncionarioView view = FuncionarioView.GetInstance((PrincipalView) principalView);
            IFuncionarioRepository repository = new FuncionarioRepository(sqlConnectionString);

            new FuncionarioPresenter(view, repository);
        }

        private void ShowTicketView(object sender, EventArgs e)
        {
            ITicketView view = TicketView.GetInstance((PrincipalView) principalView);
            ITicketRepository repository = new TicketRepository(sqlConnectionString);
            IFuncionarioRepository funcionarioRepository = new FuncionarioRepository(sqlConnectionString);

            new TicketPresenter(view, repository, funcionarioRepository);
        }
    }
}
