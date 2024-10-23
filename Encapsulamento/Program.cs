class Program
{
    static void Main()
    {
        try
        {
            Pessoa pessoa = new Pessoa();
            pessoa.Nome = "Girsely Máximo";
            pessoa.Idade = 26;
            pessoa.Telefone = "(81)985607671";
            pessoa.Endereco = "Rua 40,N 85";
            pessoa.Email = "girsely@gmail.com";

            Console.WriteLine($"Nome: {pessoa.Nome}");
            Console.WriteLine($"Idade: {pessoa.Idade}");
            Console.WriteLine($"Telefone: {pessoa.Telefone}");
            Console.WriteLine($"Endereço: {pessoa.Endereco}");
            Console.WriteLine($"E-mail: {pessoa.Email}");
        }
        catch (ArgumentException ex)
        {
            Console.WriteLine($"Erro: {ex.Message}");
        }
    }
}
// No Main, usei um bloco try-catch para capturar possíveis exceções geradas durante a configuração dos atributos.
//Com isso, a classe Pessoa está encapsulada corretamente, e as validações são realizadas conforme solicitado.