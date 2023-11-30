using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace POO_dotnet.Models
{
    public class Diretor : Professor
    {
        public sealed override void Apresentar() //Nenhuma classe filha pode sobrescrever um método Sealed (significa um ponto final), serve tanto para o método quanto para a classe
        {
            Console.WriteLine($"Diretor!");
        }
    }
}