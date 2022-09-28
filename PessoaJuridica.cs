using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace FS6_Sistema_UC12
{
    public class PessoaJuridica : Pessoa
    {
        public string? cnpj { get; set; }
        public string? razaoSocial { get; set; }

          public override void PagarImposto(float rendimento){}
            //imposto de pessoa juridica...

            public bool ValidarCNPJ(string cnpj){
                if(cnpj.Length >= 14 && (cnpj.Substring(cnpj.Length - 4)) == "0001"){
                    return true;
                }else{
                    return false;
                }
            }
        }
    }
