using propriedades_metodos_construtores.Models;

Pessoa pessoa1 = new Pessoa(nome: "Marcelo", sobrenome: "Gonçalves");
Pessoa pessoa2 = new Pessoa(nome: "Vanessa", sobrenome: "Albuquerque");

Curso cursoDeCSharp = new Curso();
cursoDeCSharp.Nome = "CSharp";
cursoDeCSharp.Alunos = new List<Pessoa>();

cursoDeCSharp.AdicionarAluno(pessoa1);
cursoDeCSharp.AdicionarAluno(pessoa2);
cursoDeCSharp.ListarAlunos();
