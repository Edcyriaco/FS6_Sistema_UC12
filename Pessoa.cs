using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace FS6_Sistema_UC12
{
    public abstract class Pessoa
    {
        public string Nome { get; set; }
        public Endereco? endereco { get; set; }


        public abstract double PagarImposto(float rendimento);
    }
}