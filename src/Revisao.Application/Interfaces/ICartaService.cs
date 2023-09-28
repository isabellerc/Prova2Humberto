using Revisao.Application.ViewModels;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Revisao.Application.Interfaces
{
    public interface ICartaService
    {
        IEnumerable<CartaViewModel> ObterTodos();
        Task<CartaViewModel> ObterPorId(Guid id);
        Task<IEnumerable<CartaViewModel>> ObterPorCategoria(int codigo);

        //void Adicionar(CartaViewModel carta);
        void Adicionar(NovaCartaViewModel novaCartaViewModel);
        void Atualizar(CartaViewModel carta);
       // public void Adicionar(NovaCartaViewModel novaCartaViewModel);
    }
}
