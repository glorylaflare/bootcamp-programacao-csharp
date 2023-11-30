using POO_dotnet.Interfaces;
using POO_dotnet.Models;

Computador computer = new();

Corrente c = new();
c.Creditar(500);
c.ExibirSaldo();

Pessoa p1 = new()
{
    Nome = "Leonardo",
    Idade = 30
};
p1.Apresentar();

ContaCorrente c1 = new(123, 1000);
c1.ExibirSaldo();
c1.Sacar(500);
c1.ExibirSaldo();

Aluno a1 = new()
{
    Nome = "Pedro",
    Idade = 22,
    Nota = 8
};
a1.Apresentar();

Professor pf1 = new()
{
    Nome = "Samantha",
    Idade = 43,
    Salario = 2300
};
pf1.Apresentar();

ICalculadora calc = new Calculadora();
Console.WriteLine(calc.Multiplicar(3,9));