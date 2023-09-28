using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Revisao.Application.ViewModels
{
    public class NovaCartaViewModel
    {
        public string nomeCrianca { get; set; }

        public string endereco { get; set; }

        public string bairro { get; set; }

        public string cidade { get; set; }

        public string estado { get; set; }

        public int idade { get; set; }
      
        public string textoCarta { get; set; } 
    }
}
