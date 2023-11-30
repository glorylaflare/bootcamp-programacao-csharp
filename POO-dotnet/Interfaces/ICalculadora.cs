using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace POO_dotnet.Interfaces
{
    public interface ICalculadora
    {
        //Método sem corpo
        int Somar(int num1, int num2); 
        int Subtrair(int num1, int num2);
        int Multiplicar(int num1, int num2);
        //Método com corpo
        int Dividir(int num1, int num2)
        {
            return num1 / num2;
        }
    }
}