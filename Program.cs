using System;
class Pessoa
{  
  private string nome;
  private int idade;
    public Pessoa(string n, int i)
    {
        nome = n;
        idade = i;
    }
    public string GetNome()
    {
        return nome;
    }
    public int GetIdade()
    {
        return idade;
    }
}
class Program
{
    static void Main()
    {
       string n = Console.ReadLine();
       int idade = int.Parse(Console.ReadLine());
       Pessoa p1 = new Pessoa(n, idade);      
       Console.WriteLine($"Nome: {n}, Idade: {idade}");
    }
}