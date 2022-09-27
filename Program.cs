namespace FS6_Sistema_UC12{
    class Program{
        static void Main(string[] args)
        {
           //Pessoa Maria = new Pessoa();
           PessoaFisica Maria = new PessoaFisica();

           PessoaJuridica Jequiti = new PessoaJuridica();

           Jequiti.cnpj = "987654";
           Jequiti.Nome = "Jequiti do silvio";
           

           Maria.cpf = "123456";
           Maria.Nome = "Maria Pereira";
           Maria.Endereco = "Rua X, N° 48";
           Maria.enderecoComercial = true;

           Console.WriteLine(Jequiti.cnpj);
           Console.WriteLine(Jequiti.Nome);
           Console.WriteLine(Maria.Nome);
           Console.WriteLine(Maria.Endereco);
           Console.WriteLine(Maria.enderecoComercial);
           Console.WriteLine(Maria.cpf);

        }
    }

}