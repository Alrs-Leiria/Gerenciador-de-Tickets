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
        }

        private void ShowFuncionarioView(object sender, EventArgs e)
        {
            IFuncionarioView view = FuncionarioView.GetInstance((PrincipalView) principalView);
            IFuncionarioRepository repository = new FuncionarioRepository(sqlConnectionString);

            new FuncionarioPresenter(view, repository);
        }
    }
}
