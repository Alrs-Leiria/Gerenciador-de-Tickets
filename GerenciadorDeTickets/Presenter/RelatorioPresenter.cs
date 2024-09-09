using GerenciadorDeTickets.Models;
using GerenciadorDeTickets.Relatorios.WinForms;
using GerenciadorDeTickets.Views;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace GerenciadorDeTickets.Presenter
{
    public class RelatorioPresenter
    {
        private IRelatorioView view;
        private IFuncionarioRepository funcionarioRepository;
        private BindingSource funcionarioBindingSource;
        private IEnumerable<RelatorioModel> funcionarioList;
        private FuncionarioModel funcionarioModel;

        public RelatorioPresenter(IRelatorioView view, IFuncionarioRepository funcionarioRepository)
        {
            this.view = view;
            this.funcionarioRepository = funcionarioRepository;

            this.funcionarioBindingSource = new BindingSource();

            this.view.LoadRelatorioEvent += LoadRelatorioEvent;
            this.view.FuncionarioId_Leave += FuncionairoId_Leave;
            this.view.PrintEvent += PrintRelatorioList;

            this.view.SetDadosBidingSource(funcionarioBindingSource);

            this.view.Show();

        }
        public void LoadFuncionarioNome()
        {
            funcionarioModel = funcionarioRepository.GetById(Convert.ToInt32(view.FuncionarioId));
            view.FuncionarioNome = funcionarioModel.Nome;
            view.FuncionarioId = funcionarioModel.Id.ToString();
        }

        private void FuncionairoId_Leave(object sender, EventArgs e)
        {
            if (!int.TryParse(view.FuncionarioId, out int id))
            {
                MessageBox.Show("Id informado não é válido!");
                view.FuncionarioId = "0";
                view.FuncionarioNome = "";
            }
            else
            {
                LoadFuncionarioNome();
            }
        }

        private DataTable GerarDadosRelatorioTotalTickets(BindingSource funcionarioBindingSource)
        {
            DataTable dt = new DataTable();

            dt.Columns.Add("IdFuncionario");
            dt.Columns.Add("NomeFuncionario");
            dt.Columns.Add("CpfFuncionario");
            dt.Columns.Add("QuantidadeTicket");
            dt.Columns.Add("DataEntregaTicket");

            foreach (RelatorioModel relatorio in funcionarioBindingSource.List)
            {
                dt.Rows.Add(
                    relatorio.IdFuncionario.ToString(),
                    relatorio.NomeFuncionario,
                    relatorio.CpfFuncionario,
                    relatorio.QuantidadeTicket,
                    relatorio.DataEntregaTicket.ToString("dd/MM/yyyy")
                );
            }
            return dt;
        }

        private void LoadRelatorioEvent(object sender, EventArgs e)
        {

            LoadRelatorioList();
        }
        private void PrintRelatorioList(object sender, EventArgs e)
        {
            var dt = GerarDadosRelatorioTotalTickets(funcionarioBindingSource);
            
            using (var frm = new TotalTicketsFuncionario(dt, view.TotalQuantidadeTickets))
            {
                frm.ShowDialog();
            }
        }
        private bool ValidateParameters() 
        {

            if (view.DataInicio <= view.DataFim)
            {
                return true;
            }
            else
            {
                return false;
            }          
        }

        private void LoadRelatorioList()
        {
            funcionarioList = funcionarioRepository.GetTotalTickets(view.FuncionarioId, view.DataInicio.ToString("yyyy-MM-dd"), view.DataFim.ToString("yyyy-MM-dd"), view.IsChecked);
            funcionarioBindingSource.DataSource = funcionarioList;

            int totalTickets = funcionarioList.Sum(f => f.QuantidadeTicket);
            view.TotalQuantidadeTickets = totalTickets.ToString();
        }
    }
}
