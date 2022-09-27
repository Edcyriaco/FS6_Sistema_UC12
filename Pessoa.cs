using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace FS6_Sistema_UC12
{
    public class Pessoa
    {
        public string Nome { get; set; }

        public string Endereco{ get; set; } 
        
        public bool enderecoComercial { get; set; }

        public void PagarImposto(){}
    }
}