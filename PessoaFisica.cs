using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace FS6_Sistema_UC12
{
    public class PessoaFisica : Pessoa
    {
        public string? cpf { get; set; }

        public DateTime dataNasc { get; set; }
        public override void PagarImposto(float rendimento)
        {
            //imposto de pessoa fisica...
        }

        public bool ValidarDataNascimento(DateTime dataNasc){
            
            //tipo nomedavariavel = (esta recebendo) biblioteca.função
            DateTime dataAtual= DateTime.Today; 
            double anos = (dataAtual - dataNasc).TotalDays / 365;

            if (anos >= 18){
                return true;
            }else {
                return false;
            }
        }

    }
}