namespace FS6_Sistema_UC12{
    class Program{
        static void Main(string[] args)
        {
          
        Endereco end = new Endereco();
        end.logradouro = "Rua X";
        end.numero = 100;
        end.complemento = "Perto do senai";
        end.enderecoComercial = false;

        PessoaFisica Maria = new PessoaFisica();
        Maria.endereco =end;
        Maria.cpf = "12345";
        Maria.dataNasc = new DateTime (2022, 08, 02, 02,35,23);
        Maria.Nome = "Maria Pereira";

        
       // Console.WriteLine(Maria.endereco.logradouro);
        //Console.WriteLine(Maria.endereco.numero);
        //Console.WriteLine(Maria.endereco.complemento);
        //Console.WriteLine(Maria.endereco.enderecoComercial);
        //Console.WriteLine(Maria.Nome);
        //Console.WriteLine(Maria.cpf);
        //Console.WriteLine(Maria.dataNasc);

        // O ______ , cujo cpf é ____ e faz aniversario no dia ___ mora na ____ numero ____
           //concatenação
        //Console.WriteLine("A " + Maria.Nome + ", cujo CPF é " + Maria.cpf + " e nasceu no dia " + Maria.dataNasc + " mora na " + Maria.endereco.logradouro + " numero " + Maria.endereco.numero );

    //interpolação
        //Console.WriteLine($"A { Maria.Nome}, cujo CPF é {Maria.cpf}, e faz aniversario no dia {Maria.dataNasc} mora na {Maria.endereco.logradouro} numero {Maria.endereco.numero} ");
               //Console.WriteLine(Maria.ValidarDataNascimento(Maria.dataNasc));
              bool idadeValidada =(Maria.ValidarDataNascimento(Maria.dataNasc));

              if(idadeValidada == true)
              {
                Console.WriteLine(" Seu Cadastro Foi Aprovado Com Sucesso ");
                  Console.BackgroundColor = ConsoleColor.Red;
                Console.ForegroundColor = ConsoleColor.DarkGreen;
              Console.WriteLine("*************************************************************************************************************************");
              Console.WriteLine("*                                 SENAI  -  Cadastro de Pessoas                                                         *");
              Console.WriteLine("*                                                                                                                       *");
              Console.WriteLine("*                                                                                                                       *");
              Console.WriteLine("*                                                                                                                       *");
              Console.WriteLine("*                             Seu Cadastro Foi Aprovado Com Sucesso                                                     *");                              
              Console.WriteLine("*                                                                                                                       *");
              Console.WriteLine("*************************************************************************************************************************");
              Console.ResetColor();

              }else{
                Console.BackgroundColor = ConsoleColor.Black;
                Console.ForegroundColor = ConsoleColor.DarkGreen;
              Console.WriteLine("*************************************************************************************************************************");
              Console.WriteLine("*                                 SENAI  -  Cadastro de Pessoas                                                         *");
              Console.WriteLine("*                                                                                                                       *");
              Console.WriteLine("*                                                                                                                       *");
              Console.WriteLine("*                                                                                                                       *");
              Console.WriteLine("*                     Seu Cadastro Foi Reprovado Por Motivos de Idade Minima Não Atingida                               *");                              
              Console.WriteLine("*                                                                                                                       *");
              Console.WriteLine("*************************************************************************************************************************");
              Console.ResetColor();
              }

              

                    

    


        }
    }

}