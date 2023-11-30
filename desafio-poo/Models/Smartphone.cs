using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace desafio_poo.Models
{
    public abstract class Smartphone
    {
        public string? Numero { get; set; }
        // TODO: Implementar as propriedades faltantes de acordo com o diagrama
        public string? Modelo { get; set; }
        public string? IMEI { get; set; }
        public int Memoria { get; set; }

        public Smartphone(string numero, string modelo, string imei, int memoria)
        {
            this.Numero = numero;
            // TODO: Passar os parâmetros do construtor para as propriedades
            this.Modelo = modelo;
            this.IMEI = imei;
            this.Memoria = memoria;
        }

        public void Ligar()
        {
            Console.WriteLine("Ligando...");
        }

        public void ReceberLigacao()
        {
            Console.WriteLine("Recebendo ligação...");
        }

        public abstract void InstalarAplicativo(string nomeApp);
    }
}