using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace POO_dotnet.Models
{
    public class Professor : Pessoa
    {
        public Professor()
        {
            
        }
        public Professor(string nome) : base (nome)
        {
            
        }
        public decimal Salario { get; set; }

        public override void Apresentar() //Override sobrescreve o valor da classe herdada
        {
            Console.WriteLine($"Olá, meu nome é {Nome} e tenho {Idade} anos, sou professor e ganho {Salario}!");
        }
    }
}