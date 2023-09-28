using Microsoft.AspNetCore.Mvc;
using Revisao.Application.Interfaces;
using Revisao.Application.ViewModels;
using Revisao.Domain.Entities;

namespace Revisao.API.Controllers
{
    [ApiController]
    [Route("[controller]")]
    public class CartaController : ControllerBase
    {
        private readonly ICartaService _cartaService;

        public CartaController(ICartaService cartaService)
        {
            _cartaService = cartaService;
        }

        //[HttpPost(Name = "Adicionar")] //
        //public IActionResult Post(CartaViewModel nCartaViewModel)
        //{
        //    _cartaService.Adicionar(novaCartaViewModel);
        //    return Ok("Registro adicionado com sucesso!");
        //}

        [HttpPost(Name = "Adicionar")] //
        public IActionResult Post(NovaCartaViewModel novaCartaViewModel)
        {
            _cartaService.Adicionar(novaCartaViewModel);
            return Ok("Registro adicionado com sucesso!");
        }

        [HttpGet(Name = "ObterTodos")] //
        public IActionResult Get()
        {
            return Ok(_cartaService.ObterTodos());
        }
        //[HttpGet(Name = "ObterTodos")] 
        //public async Task<IActionResult> Get()
        //{
        //    var cartas = await _cartaService.ObterTodos();
        //    return Ok(cartas);
        //}


        //public IEnumerable<Carta> ObterTodos()
        //{
        //    return LerCartasDoArquivo();
        //}

        //public IActionResult Get()
        //{
        //    List<CartaViewModel> cartas = LerCartasDoArquivo();
        //    return Ok(cartas);
        //}
    }
}
