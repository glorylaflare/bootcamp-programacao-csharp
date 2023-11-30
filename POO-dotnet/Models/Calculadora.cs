using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using POO_dotnet.Interfaces;

namespace POO_dotnet.Models
{
    public class Calculadora : ICalculadora //Calculadora implementa ICalculadora
    //Precisa implementar todos os métodos, caso o método não tenha corpo na interface
    {
        public int Somar(int num1, int num2)
        {
            return num1 + num2;
        }

        public int Somar(int num1, int num2, int num3)
        {
            return num1 + num2 + num3;
        }

        public int Subtrair(int num1, int num2)
        {
            return num1 - num2;
        }

        public int Multiplicar(int num1, int num2)
        {
            return num1 * num2;
        }
    }
}