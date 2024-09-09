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
    internal class FuncionarioPresenter
    {
        private IFuncionarioView view;
        private IFuncionarioRepository repository;
        private BindingSource funcionarioBindingSource;
        private IEnumerable<FuncionarioModel> funcionarioList;

        public FuncionarioPresenter(IFuncionarioView view, IFuncionarioRepository repository)
        {
            this.view = view;
            this.repository = repository;
            this.funcionarioBindingSource = new BindingSource();
        
            this.view.AddNewEvent += AddNewFuncionario;
            this.view.CancelEvent += CancelAction;
            this.view.SearchEvent += SearchFuncionario;
            this.view.EditEvent   += LoadSelectedFuncionarioToEdit;
            this.view.SaveEvent   += SaveFuncionario;
            this.view.PrintEvent  += PrintEvent;

            this.view.SetFuncionarioBidingSource(funcionarioBindingSource);

            LoadFuncionarioList();

            this.view.Show();

        }

        private DataTable GerarDadosRelatorioFuncionario(BindingSource funcionarioBindingSource) 
        { 
            DataTable dt = new DataTable();

            dt.Columns.Add("Id");
            dt.Columns.Add("Nome");
            dt.Columns.Add("Cpf");
            dt.Columns.Add("Situacao");
            dt.Columns.Add("DataAlteracao");

            foreach (FuncionarioModel funcionario in funcionarioBindingSource.List)
            {
                dt.Rows.Add(
                    funcionario.Id.ToString(),
                    funcionario.Nome,
                    funcionario.Cpf,
                    funcionario.Situacao.ToString(),
                    funcionario.DataAlteracao.ToString("dd/MM/yyyy") 
                );
            }
            return dt;
        } 
        private void PrintEvent(object sender, EventArgs e)
        {
            var dt = GerarDadosRelatorioFuncionario(funcionarioBindingSource);
            using(var frm = new FuncionarioList(dt))
            {
                frm.ShowDialog();
            }
        }
        private void AddNewFuncionario(object sender, EventArgs e)
        {
            view.IsEdit = false;
        }
        private void LoadSelectedFuncionarioToEdit(object sender, EventArgs e)
        {
            var funcionario = (FuncionarioModel)funcionarioBindingSource.Current;
            view.FuncionarioId            = funcionario.Id.ToString();
            view.FuncionarioNome          = funcionario.Nome;    
            view.FuncionarioCpf           = funcionario.Cpf.ToString();
            view.FuncionarioSituacao      = funcionario.Situacao.ToString(); 
            view.FuncionarioDataAlteracao = funcionario.DataAlteracao.ToString("dd/MM/yyyy");

            view.IsEdit = true;
        }
        private void SaveFuncionario(object sender, EventArgs e)
        {
            var model = new FuncionarioModel();

            model.Id = Convert.ToInt32(view.FuncionarioId);
            model.Nome = view.FuncionarioNome.ToString();
            model.Cpf = view.FuncionarioCpf.ToString();
            model.Situacao = Convert.ToChar(view.FuncionarioSituacao);

            try
            {
                new Common.ModelDataValidation().Validate(model);
                if (view.IsEdit)
                { 
                    repository.Edit(model);
                    view.Message = " Funcionario atulizado com sucesso! ";
                }
                else
                {
                    repository.Add(model);
                    view.Message = " Funcionario adicionado com sucesso!";
                }
                view.IsSuccessful = true;
                LoadFuncionarioList();
                CleanViewFields();
            }
            catch (Exception ex) 
            {
                view.IsSuccessful = false; 
                view.Message = "Erro ao tentar salvar: " + ex.Message;
            }
        }

        private void CleanViewFields()
        {
            view.FuncionarioId = "0";
            view.FuncionarioNome = "";
            view.FuncionarioCpf = "";
            view.FuncionarioSituacao = "";
            view.FuncionarioDataAlteracao =  "";
        }

        private void CancelAction(object sender, EventArgs e)
        {
           CleanViewFields();
        }

        private void SearchFuncionario(object sender, EventArgs e)
        {
            bool emptyValue = string.IsNullOrWhiteSpace(this.view.SearchValue);
            if(emptyValue == false)
            {
                funcionarioList = repository.GetByValue(this.view.SearchValue);
            }
            else
            {
                funcionarioList = repository.GetAll();
            }
            funcionarioBindingSource.DataSource = funcionarioList;
        }

        private void LoadFuncionarioList()
        {
            funcionarioList = repository.GetAll();
            funcionarioBindingSource.DataSource = funcionarioList;
        }
    }
}
