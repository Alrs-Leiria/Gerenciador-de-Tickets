using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GerenciadorDeTickets.Models
{
    public interface IFuncionarioRepository
    {
        void Add(FuncionarioModel funcionarioModel);
        void Edit(FuncionarioModel funcionarioModel);
        IEnumerable<FuncionarioModel> GetAll();
        IEnumerable<FuncionarioModel> GetByValue(string value);
        IEnumerable<RelatorioModel> GetTotalTickets(string value, string dataInicio, string dataFim, bool agrupar = false);
        FuncionarioModel GetById(int id);
    }
}
