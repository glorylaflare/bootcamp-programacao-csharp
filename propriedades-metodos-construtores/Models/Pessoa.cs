using System;
using System.Collections.Generic;
using System.Linq;
using System.Reflection.Emit;
using System.Threading.Tasks;

namespace propriedades_metodos_construtores.Models
{
    public class Pessoa
    {
        
        public Pessoa()
        {

        }
        public Pessoa(string nome, string sobrenome) // Constructor
        {
            Nome = nome;
            Sobrenome = sobrenome;
        }
        private string _nome; //Campo que armazena o "nome"
        private int _idade; //Campo que armazena a "idade"
        public string Nome 
        { 
            get => _nome.ToUpper(); //Transforma o texto em maiúsculo {Body Expressions}
            
            set
            {
                if(value == "")
                {
                    throw new ArgumentException("O nome não pode ser vazio"); //Envia erro em caso de o campo nome está vazio
                }
                _nome = value;
            } 
        }
        public string Sobrenome { get; set; }
        public string NomeCompleto => $"{Nome} {Sobrenome}".ToUpper(); //Propriedade só de Get (Somente leitura)
        public int Idade 
        { 
            get => _idade; 
            set 
            {
                if(value < 0)
                {
                    throw new ArgumentException("A idade não pode ser menor que zero");
                }
                _idade = value;
            } 
        }

        public void Apresentar()
        {
            Console.WriteLine($"Nome: {NomeCompleto}, Idade: {Idade}");
        }
    }
}