using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace POO_dotnet.Models
{
    public class Aluno : Pessoa //Herança
    {
        public Aluno()
        {
            
        }
        public Aluno(string nome) : base(nome)
        {
            
        }
        public double Nota { get; set; }

        public override void Apresentar() //Override sobrescreve o valor da classe herdada
        {
            Console.WriteLine($"Olá, meu nome é {Nome} e tenho {Idade} anos, e sou um aluno nota {Nota}!");
        }
    }
}