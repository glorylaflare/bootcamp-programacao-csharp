using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace POO_dotnet.Models
{
    public class Corrente : Conta
    {
        public override void Creditar(decimal valor) //Classe abstrata
        {
            saldo += valor;
        }
    }
}