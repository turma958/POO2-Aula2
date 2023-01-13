var pessoa1 = new PessoaR("Davi", "email", "cpf");

var pessoa2 = pessoa1 with { Nome = "Othon" };

//MudarPessoa(pessoa1);
//var pessoa2 = new PessoaR();
//pessoa2.Nome = "Davi";

//Console.WriteLine(pessoa1 == pessoa2);
Console.WriteLine(pessoa1);
Console.WriteLine(pessoa2);
Console.ReadLine();

//void MudarPessoa(PessoaR pessoaR)
//{
//    pessoaR.Nome = "Davi mudado";
//}

record PessoaR(string Nome, string Email, string CPF);

class Pessoa
{
    public string Nome { get; set; }
}