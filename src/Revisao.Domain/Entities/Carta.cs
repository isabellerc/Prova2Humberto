using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Revisao.Domain.Entities
{    
    public class Carta
    {
        #region Construtores
        public Carta(string nomeCrianca, string endereco, string bairro, string cidade, string estado, int idade, string textoCarta)
        {
  
            nomeCrianca = nomeCrianca;
            endereco = endereco;
            bairro = bairro;
            cidade = cidade;
            estado = estado;
            idade = idade;
            textoCarta = textoCarta;

        }

        
        #endregion

        #region Propriedades

        public string nomeCrianca { get; private set; }

        public string endereco { get; private set; }

        public string bairro { get; private set; }

        public string cidade { get; private set; }

        public string estado { get; private set; }

        public int idade { get; private set; }
        
        public string textoCarta { get; private set; } 
        

        #endregion
    }
}
