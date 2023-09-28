using AutoMapper;
using Revisao.Application.ViewModels;
using Revisao.Domain.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Revisao.Application.AutoMapper
{
	public class ApplicationToDomain : Profile
	{
		public ApplicationToDomain()
		{

            CreateMap<CartaViewModel, Carta>()
               .ConstructUsing(q => new Carta(q.nomeCrianca, q.endereco, q.bairro, q.cidade, q.estado, q.idade, q.textoCarta));

            CreateMap<NovaCartaViewModel, Carta>()
               .ConstructUsing(q => new Carta(q.nomeCrianca, q.endereco, q.bairro, q.cidade, q.estado, q.idade, q.textoCarta));
            

        }
	}
}
