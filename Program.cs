namespace FS6_Sistema_UC12{
    class Program{
        static void Main(string[] args)
        {              
              Console.Clear();

            void BarraCarregamento(string textoCarregamento, string icone){
                Console.WriteLine(textoCarregamento);
                Thread.Sleep(500);
                for (var contador = 0; contador < 03; contador++)
                {
                    Console.Write(icone);
                    Thread.Sleep(500);
                    }
                    Console.WriteLine("");
            }
                     
            Console.ForegroundColor = ConsoleColor.DarkGreen;
            Console.BackgroundColor = ConsoleColor.Black;
                Console.WriteLine(@$"
=================================================
|        Seja Bem Vindo ao nosso Sistema        |
|          de Cadastro de Pessoa                |
|            Física e Jurídica                  |
=================================================");
BarraCarregamento("Iniciando",".");
BarraCarregamento("Procurando a solução do seu problema ! ",".");
Console.Clear();

string  tecladigitada;

 do{
Console.WriteLine(@$"
=================================================
|          Escolha uma das opções abaixo        |           
=================================================
|             1 - Pessoa Física                 |
|             2 - Pessoa Jurídica               |
|                                               |
|               0 - Sair                        |
|                                               |
=================================================
");


                tecladigitada = Console.ReadLine();

                switch (tecladigitada)
                {
                    case "1":
                    Endereco Endresid = new Endereco();
                    Endresid.logradouro = "Rua X";
                    Endresid.numero = 100;
                    Endresid.complemento = "Perto do senai";
                    Endresid.enderecoComercial = false;

                       PessoaFisica Maria = new PessoaFisica();
                       Maria.endereco = Endresid;
                       Maria.cpf = "12345678";
                       Maria.dataNasc = new DateTime (1957, 08, 06, 05, 40, 55);
                       Maria.Nome = "Maria Pereira";

                   Console.WriteLine(Maria.endereco.logradouro);
                   Console.WriteLine(Maria.endereco.numero);
                   Console.WriteLine(Maria.endereco.complemento);
                   Console.WriteLine(Maria.endereco.enderecoComercial);
                   Console.WriteLine(Maria.Nome);
                   Console.WriteLine(Maria.cpf);
                   Console.WriteLine(Maria.dataNasc);

                   bool idadeValidada = Maria.ValidarDataNascimento(Maria.dataNasc);
                
                    if (idadeValidada == true)
            {
                Console.ForegroundColor = ConsoleColor.DarkGreen;
                Console.WriteLine("***********************************************************************");
                Console.WriteLine("!                SENAI - Cadastro de Pessoas                          !");
                Console.WriteLine("!                                                                     !");
                Console.WriteLine("!                Seu Cadastro Foi Aprovado                            !");
                Console.WriteLine("***********************************************************************");
                 Console.ForegroundColor = ConsoleColor.DarkGreen;
            }else{
                Console.ForegroundColor = ConsoleColor.Red;
                Console.WriteLine("***********************************************************************");
                Console.WriteLine("*                SENAI - Cadastro de Pessoas                          *");
                Console.WriteLine("*                                                                     *");
                Console.WriteLine("* Seu Cadastro Foi Reprovado Por Motivos de Idade Mínima Não Atingida *");
                Console.WriteLine("*                                                                     *");
                Console.WriteLine("***********************************************************************");
                Console.ForegroundColor = ConsoleColor.DarkGreen;
            }  

                        break;
                    case "2":
                     Endereco endcom = new Endereco();

                     Console.WriteLine("Digire seu Lougradouro");
                     endcom.logradouro = Console.ReadLine();

                     endcom.numero = 100;
                     endcom.complemento = "Perto do senai";
                     endcom.enderecoComercial = true;

                     PessoaJuridica MP = new PessoaJuridica();
                     MP.endereco = endcom;
                     MP.cnpj = "123567899001";
                     MP.razaoSocial = "Pessoa Juridica";
                     bool cnpjvalidado = MP.ValidarCNPJ(MP.cnpj);

                     
                     Console.WriteLine(MP.endereco.numero);
                     Console.WriteLine(MP.endereco.complemento);
                     Console.WriteLine(MP.endereco.enderecoComercial);
                     Console.WriteLine(MP.endereco.logradouro);
                     Console.WriteLine(MP.Nome);
                     Console.WriteLine(MP.cnpj);
                     
                     

                     if(cnpjvalidado == true){
                     Console.WriteLine("Verdadeiro - O CNPJ é válido");
                    }else{
                      Console.WriteLine("Falso - O CNPJ é inválido");
                    }
                        break;
                    case "0":
                    Console.Clear();
                    Console.WriteLine("Obrigado por ultilizar o nosso sistema... até a proxima.");
                    BarraCarregamento("Encerrando",".");
                    
                        break;
                    default:
                        Console.WriteLine("Opção inválida, por favor digite uma das opções apresentadas ");
                        break;
                }

            } while (tecladigitada != "0");
            Console.ResetColor();
            Console.Clear();
            {

            }
        }
    }
}
