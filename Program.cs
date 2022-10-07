namespace FS6_Sistema_UC12
{
    class Program
    {
        static void Main(string[] args)
        {
            List<PessoaFisica> listaPf = new List<PessoaFisica>();
            Console.Clear();

            void BarraCarregamento(string textoCarregamento, string icone)
            {
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
            BarraCarregamento("Iniciando", ".");
            BarraCarregamento("Procurando a solução do seu problema ! ", ".");
            Console.Clear();

            string tecladigitada;

            do
            {
                Console.WriteLine(@$"
=================================================
|          Escolha uma das opções abaixo        |           
=================================================
|                 Pessoa Física                 |
|             1 - Cadastrar Pessoa Física       |
|             2 - Listar Pessoa Física          |
|             3 - Remover Pessoa Física         |
|                                               |
|                 Pessoa Jurídica               |
|             4 - Cadastrar Pessoa Jurídica     |
|             5 - Listar Pessoa Jurídica        |
|             6 - Remover Pessoa Jurídica       |
|                                               |
|             0 - Sair                          |
|                                               |
=================================================
");


                tecladigitada = Console.ReadLine();

                switch (tecladigitada)
                {
                    case "1":
                        Endereco Endresid = new Endereco();
                        Console.WriteLine($"Digite seu lougradouro");
                        Endresid.logradouro = Console.ReadLine();

                        Console.WriteLine($"Digite o número da rua residencia");
                        Endresid.numero = int.Parse(Console.ReadLine());

                        Console.WriteLine($"Digite o complemento ( Aparte enter para vazio)");
                        Endresid.complemento = Console.ReadLine();

                        Console.WriteLine($"Este endereço é comercial? S/N");
                        string oqueeledigitou = Console.ReadLine().ToUpper();

                        if (oqueeledigitou == "S")
                        {
                            Endresid.enderecoComercial = true;
                        }
                        else
                        {
                            Endresid.enderecoComercial = false;
                        }


                        //Endresid.logradouro = "Rua X";
                        //Endresid.numero = 100;
                        //Endresid.complemento = "Perto do senai";
                        //Endresid.enderecoComercial = false;

                        PessoaFisica novaPF = new PessoaFisica();
                        novaPF.endereco = Endresid;
                        Console.WriteLine($"Digite seu CPF (somente números)");
                        novaPF.cpf = Console.ReadLine();

                        Console.WriteLine($"Digite seu nome");
                        novaPF.Nome = Console.ReadLine();

                        Console.WriteLine($"Digite o valor do seu rendimento mensal");
                        novaPF.rendimento = float.Parse(Console.ReadLine());

                        Console.WriteLine($"Digite sua data de nascimento");
                        novaPF.dataNasc = DateTime.Parse(Console.ReadLine());

                        //Maria.endereco = Endresid;
                        //Maria.cpf = "12345678";
                        //Maria.dataNasc = new DateTime(1957, 08, 06, 05, 40, 55);
                        //Maria.Nome = "Maria Pereira";

                        Console.WriteLine(novaPF.endereco.logradouro);
                        Console.WriteLine(novaPF.endereco.numero);
                        Console.WriteLine(novaPF.endereco.complemento);
                        Console.WriteLine(novaPF.endereco.enderecoComercial);
                        Console.WriteLine(novaPF.Nome);
                        Console.WriteLine(novaPF.cpf);
                        Console.WriteLine(novaPF.dataNasc);
                        double ImpostoPago = novaPF.PagarImposto(2000);
                        Console.WriteLine($"Ela vai pagar R${ImpostoPago},00 Reais de imposto");

                        bool idadeValidada = novaPF.ValidarDataNascimento(novaPF.dataNasc);

                        if (idadeValidada == true)
                        {
                            Console.ForegroundColor = ConsoleColor.DarkGreen;
                            Console.WriteLine("***********************************************************************");
                            Console.WriteLine("|                SENAI - Cadastro de Pessoas                          |");
                            Console.WriteLine("|                                                                     |");
                            Console.WriteLine("|                Seu Cadastro Foi Aprovado                            |");
                            Console.WriteLine("***********************************************************************");
                            listaPf.Add(novaPF);
                            Console.ForegroundColor = ConsoleColor.DarkGreen;
                        }
                        else
                        {
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
                        //Listar pessoa física 
                        foreach (var cadaItem in listaPf)
                        {
                            Console.WriteLine($"{cadaItem.Nome}, {cadaItem.cpf}, {cadaItem.dataNasc}, {cadaItem.rendimento}, {cadaItem.endereco.enderecoComercial}");
                        }
                        break;
                    case "3":
                        //Remover pessoa física
                        Console.WriteLine("Digite o CPF que deseja remover [Somente Números");
                        string cpfProcurado = Console.ReadLine();

                        PessoaFisica pessoaEncontrada = listaPf.Find(cadaItem => cadaItem.cpf == cpfProcurado);
                        if (pessoaEncontrada != null){
                            listaPf.Remove(pessoaEncontrada);
                            Console.WriteLine("Cadastro Removido");

                        }else{
                            Console.WriteLine("CPF não encotrado");

                        }
                        
                        break;
                    case "4":
                        //Cadastrar pessoa Jurídica
                        break;
                    case "5":
                        //Listar pessoa Jurídica
                        break;
                    case "6":
                        //Remover Pessoa Jurídica
                        break;

                    case "0":
                        Console.Clear();
                        Console.WriteLine("Obrigado por ultilizar o nosso sistema... até a proxima.");
                        BarraCarregamento("Encerrando", ".");

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
/*Endereco endcom = new Endereco();

 Console.WriteLine("Digire seu Lougradouro");
 endcom.logradouro = Console.ReadLine();

 endcom.numero = 100;
 endcom.complemento = "Perto do senai";
 endcom.enderecoComercial = true;

 PessoaJuridica MP = new PessoaJuridica();
 MP.endereco = endcom;
 MP.cnpj = "12356789900001";
 MP.razaoSocial = "Pessoa Juridica";
 double ImpostoPago2 = MP.PagarImposto(10000);
 Console.WriteLine($"Ela vai pagar R${ImpostoPago2},00 Reais de imposto");
 bool cnpjvalidado = MP.ValidarCNPJ(MP.cnpj);


 Console.WriteLine(MP.endereco.numero);
 Console.WriteLine(MP.endereco.complemento);
 Console.WriteLine(MP.endereco.enderecoComercial);
 Console.WriteLine(MP.endereco.logradouro);
 Console.WriteLine(MP.Nome);
 Console.WriteLine(MP.cnpj);



 if (cnpjvalidado == true)
 {
     Console.WriteLine("Verdadeiro - O CNPJ é válido");
 }
 else
 {
     Console.WriteLine("Falso - O CNPJ é inválido");
  }*/