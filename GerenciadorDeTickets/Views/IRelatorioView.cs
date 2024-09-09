using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace GerenciadorDeTickets.Views
{
    public interface IRelatorioView
    {
        DateTime DataInicio { get; set; }
        DateTime DataFim { get; set; }       
        string FuncionarioId { get; set; }
        string FuncionarioNome { get; set; }
        string TotalQuantidadeTickets { get; set; }
        bool IsChecked{ get; set; }
        void SetDadosBidingSource(BindingSource dataList);
        void CloseForm();

        event EventHandler<EventArgs> LoadRelatorioEvent;
        event EventHandler<EventArgs> FuncionarioId_Leave;
        event EventHandler<EventArgs> PrintEvent;
        void Show();
    }
}
