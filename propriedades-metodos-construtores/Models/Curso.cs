using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace propriedades_metodos_construtores.Models
{
    public class Curso
    {
        public string Nome { get; set; }
        public List<Pessoa> Alunos { get; set; }

        public void AdicionarAluno(Pessoa aluno)
        {
            Alunos.Add(aluno);
        }

        public int ObterQuantidadeDeAlunosMatriculados()
        {
            int quantidade = Alunos.Count;
            return quantidade;
        }

        public bool RemoverAluno(Pessoa aluno)
        {
            return Alunos.Remove(aluno);
        }

        public void ListarAlunos()
        {
            Console.WriteLine($"Alunos do curso de {Nome}");
            //Refatorando
            for (int i = 0; i < Alunos.Count; i++)
            {
                string concatenacao = "N° " + (i + 1) + " - " + Alunos[i].NomeCompleto;
                string interpolacao = $"N° {i + 1} - {Alunos[i].NomeCompleto}";
                Console.WriteLine(concatenacao);
                Console.WriteLine(interpolacao);
            }
            // foreach (Pessoa aluno in Alunos)
            // {
            //     Console.WriteLine(aluno.NomeCompleto);
            // }
        }
    }
}