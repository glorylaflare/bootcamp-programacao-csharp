using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace POO_dotnet.Models
{
    public class Pessoa
    {
        public Pessoa()
        {
            
        }
        public Pessoa(string nome)
        {
            this.Nome = nome;
        }
        public string? Nome { get; set; }
        public int Idade { get; set; }

        public virtual void Apresentar() //Virtual significa que o método pode ser sobrescrito 
        {
            Console.WriteLine($"Olá, meu nome é {Nome} e tenho {Idade} anos!");
        }
    }
}