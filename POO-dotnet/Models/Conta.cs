using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace POO_dotnet.Models
{
    public abstract class Conta //Classe abstrada serve apenas para modelo, não podendo ser estanciada
    {
        public decimal saldo;

        public abstract void Creditar(decimal valor); //Método abstrato

        public void ExibirSaldo()
        {
            Console.WriteLine($"O seu saldo é: {saldo}");
        }
    }
}