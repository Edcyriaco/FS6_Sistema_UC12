namespace FS6_Sistema_UC12
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.ForegroundColor = ConsoleColor.DarkGreen;
            Console.BackgroundColor = ConsoleColor.Black;
            Console.Write("Iniciando ");
            Thread.Sleep(500);


            for (var contador = 0; contador < 10; contador++)
            {
                Console.Write(".");
                Thread.Sleep(500);
            }
            Console.Clear();

            string opcao;
            do
            {
                Console.WriteLine(@$"
=================================================
*                                               *
*                                               *
*        Seja Bem Vindo ao nosso Sistema        *
*          de Cadastro de Pessoa                *
*            Fisica e Juridica                  *
*                                               *
*                                               *
=================================================


=================================================
|          Escolha uma das opcoes abaixo        |           
=================================================
!             1 - Pessoa Fisica                 !
!             2 - Pessoa Juridica               !
!                                               !
!               0 - Sair                        !
!                                               !
=================================================
");


                opcao = Console.ReadLine();

                switch (opcao)
                {
                    case "1":
                        break;
                    case "2":
                        break;
                    case "0":
                        break;
                    default:
                        Console.WriteLine("Opcao invalida, por favor digite uma das opcaoes apresentadas ");
                        break;


                }


            } while (opcao != "0");
            Console.ResetColor();


            {

            }
        }
    }
}
