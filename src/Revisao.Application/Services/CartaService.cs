using AutoMapper;
using Revisao.Application.Interfaces;
using Revisao.Application.ViewModels;
using Revisao.Domain.Entities;
using Revisao.Domain.Interfaces;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Revisao.Application.Services
{
    public class CartaService : ICartaService
    {
        #region - Construtores
        private readonly ICartaRepository _cartaRepository;
        private IMapper _mapper;

        public CartaService(ICartaRepository cartaRepository, IMapper mapper)
        {
            _cartaRepository = cartaRepository;
            _mapper = mapper;
        }
        #endregion

        #region - Funções
        public void Adicionar(NovaCartaViewModel novaCartaViewModel)
        {
            var novaCarta = _mapper.Map<Carta>(novaCartaViewModel);
            _cartaRepository.Adicionar(novaCarta);

        }

        public void Atualizar(CartaViewModel carta)
        {
            throw new NotImplementedException();
        }

        public Task<IEnumerable<CartaViewModel>> ObterPorCategoria(int codigo)
        {
            throw new NotImplementedException();
        }

        public Task<CartaViewModel> ObterPorId(Guid id)
        {
            throw new NotImplementedException();
        }

        public IEnumerable<CartaViewModel> ObterTodos()
        {
            return _mapper.Map<IEnumerable<CartaViewModel>>(_cartaRepository.ObterTodos());
        }
        #endregion


        //comentado daqui para baixo:
        //private readonly ICartaRepository _cartaRepository;

        //public CartaService(ICartaRepository cartaRepository)
        //{
        //    _cartaRepository = _cartaRepository;
        //}

        //public void Adicionar(NovaCartaViewModel novaCartaViewModel)
        //{
        //    _cartaRepository.Adicionar(new Carta(

        //         novaCartaViewModel.nomeCrianca,
        //         novaCartaViewModel.endereco,
        //         novaCartaViewModel.bairro,
        //         novaCartaViewModel.cidade,
        //         novaCartaViewModel.estado,
        //         novaCartaViewModel.idade,
        //         novaCartaViewModel.textoCarta
        //        ));
        //}




        //public IEnumerable<CartaViewModel> ObterTodos()
        //{
        //    return _mapper.Map<IEnumerable<CartaViewModel>>(_cartaRepository.ObterTodos());
        //}

        //public void Atualizar(CartaViewModel carta)
        //{
        //    throw new NotImplementedException();
        //}

        //public Task<IEnumerable<CartaViewModel>> ObterPorCategoria(int codigo)
        //{
        //    throw new NotImplementedException();
        //}

        //public Task<CartaViewModel> ObterPorId(Guid id)
        //{
        //    throw new NotImplementedException();
        //}


    }
}
