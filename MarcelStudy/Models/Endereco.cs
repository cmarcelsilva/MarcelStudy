using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace MarcelStudy.Models
{
    public class Endereco
    {
        public int Id { get; set; }
        public int ContatoId { get; set; }
        public string EnderecoEnd { get; set; }
        public string Cidade { get; set; }
        public string Bairro { get; set; }
        public string Cep { get; set; }
        public List<Contato> Contato { get; set; }


    }
}
