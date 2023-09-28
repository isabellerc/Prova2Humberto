using Newtonsoft.Json;
using Revisao.Domain.Entities;
using Revisao.Domain.Interfaces;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Revisao.Data.Repositories
{
    public class CartaRepository : ICartaRepository
    {
      
        private readonly string _cartaCaminhoArquivo;
        #region - Construtor
        public CartaRepository()
        {
            _cartaCaminhoArquivo = Path.Combine(Directory.GetCurrentDirectory(),
                "FileJsonData", "carta.json");
        }

        #endregion

        #region - Funções do repositorio
        public void Adicionar(Carta carta) //MUDEI ESTAVA novaCarta
        {
            var cartas = LerCartasDoArquivo();
            //int proximoCodigo = ObterProximoCodigoDisponivel();
            //produto.SetaCodigoProduto(proximoCodigo);
            cartas.Add(carta);
            EscreverCartasNoArquivo(cartas);

            //estava assim antes
            //List<Carta> cartas = new List<Carta>();
            ////int proximoCodigo = ObterProximoCodigoDisponivel(); // retirar isso
            //cartas.Add(novaCarta);
            //EscreverCartasNoArquivo(cartas);
        }

        //talvez retirar isso
        public IEnumerable<Carta> ObterTodos()
        {
            return LerCartasDoArquivo();
        }

        



        public Carta BuscarPorId(int codigo)
        {
            throw new NotImplementedException();
        }

        public IEnumerable<Carta> BuscarTodos()
        {
            throw new NotImplementedException();
        }

        public IEnumerable<Carta> BuscarTodosAtivos()
        {
            throw new NotImplementedException();
        }

        public IEnumerable<Carta> BuscarTodosInativos()
        {
            throw new NotImplementedException();
        }
        #endregion

        #region Funções do arquivo
        private List<Carta> LerCartasDoArquivo()
        {
            if (!System.IO.File.Exists(_cartaCaminhoArquivo))
            {
                return new List<Carta>();
                
            }
            //VERIFICAR FORA DOS COLCHETES:
            string json = System.IO.File.ReadAllText(_cartaCaminhoArquivo);
            return JsonConvert.DeserializeObject<List<Carta>>(json);
        }

        

        private void EscreverCartasNoArquivo(List<Carta> cartas)
        {
            string json = JsonConvert.SerializeObject(cartas);
            System.IO.File.WriteAllText(_cartaCaminhoArquivo, json);
        }

        

        Carta ICartaRepository.BuscarPorId(int codigo)
        {
            throw new NotImplementedException();
        }

        IEnumerable<Carta> ICartaRepository.BuscarTodos()
        {
            throw new NotImplementedException();
        }

        IEnumerable<Carta> ICartaRepository.BuscarTodosAtivos()
        {
            throw new NotImplementedException();
        }

        IEnumerable<Carta> ICartaRepository.BuscarTodosInativos()
        {
            throw new NotImplementedException();
        }

        #endregion
    }
}
