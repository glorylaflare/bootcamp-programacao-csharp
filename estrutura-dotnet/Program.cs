using System.Reflection.Metadata;
using estrutura_dotnet.Models;

Pessoa pessoa1 = new Pessoa();
Pessoa pessoa2 = new();

pessoa1.Nome = "Marcelo";
pessoa1.Idade = 30;
pessoa1.Apresentar();

string apresentacao = "Olá, seja bem vindo";
int quantidade = 1;
double altura = 1.80;
decimal preco = 1.80M;
bool condicao = true;

Console.WriteLine(apresentacao);
Console.WriteLine("quantidade " + quantidade);
Console.WriteLine("altura " + altura.ToString("0.00"));
Console.WriteLine("preco " + preco);
Console.WriteLine("condicao " + condicao);

DateTime data = DateTime.Now;
Console.WriteLine(data.ToString("dd/MM/yyyy HH:mm:ss"));

// Casting
int a = Convert.ToInt32("5");
int b = int.Parse("5");

// Tipo de variáveis -> int, long, double, decimal podem ser convertido através do casting, utilizando o Parse ou o Convert
// É melhor usar o Convert

int inteiro = 5;
string c = inteiro.ToString();
// Para converter algo para uma string, utilizar apenas o ToString()

Console.WriteLine(a);

string d = "15-";
int e = 0;
int.TryParse(d, out e);

Console.WriteLine(e);

// Nova classe instanciada
Calculadora calcula = new();
calcula.Somar(10,30);
calcula.Subtrair(50,20);
calcula.Multiplicar(5,2);
calcula.Dividir(50,10);
calcula.Potencia(2,3);
calcula.Seno(30);
calcula.Cosseno(30);
calcula.Tangente(30);