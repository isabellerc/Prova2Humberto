using Revisao.Domain.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Revisao.Domain.Interfaces
{
    public interface ICartaRepository
    {

        IEnumerable<Carta> ObterTodos(); // Tirei o public
        void Adicionar(Carta Carta); // tirei o public e estava "novaCarta"
        
        public Carta BuscarPorId(int codigo); // acho que vai ter que retirar isso

        public IEnumerable<Carta> BuscarTodos();
        public IEnumerable<Carta> BuscarTodosAtivos();
        public IEnumerable<Carta> BuscarTodosInativos();
    }
}
