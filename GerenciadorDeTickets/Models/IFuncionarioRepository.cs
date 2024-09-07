using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GerenciadorDeTickets.Models
{
    internal interface IFuncionarioRepository
    {
        void Add(FuncionarioModel funcionarioModel);
        void Edit(FuncionarioModel funcionarioModel);
        IEnumerable<FuncionarioModel> GetAll();
        IEnumerable<FuncionarioModel> GetByValue(string value);
        FuncionarioModel GetById(int id);
    }
}
