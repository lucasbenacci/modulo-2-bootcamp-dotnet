using Modulo2_aulas.Models;
using Modulo2BootcampDotnet.Models;

//instanciando a classe Pessoa
Pessoa p1 = new Pessoa("Lucas", "Souza");
Pessoa p2 = new Pessoa("Claudio", "Azevedo");


//instanciando a classe Curso
Curso cursoDeIngles = new Curso();
cursoDeIngles.Nome = "Ingles";
//instanciando a lista Pessoa, criando ela vazia
cursoDeIngles.Alunos = new List<Pessoa>();

//Adicionando alunos na lista
cursoDeIngles.AdicionarAluno(p1);
cursoDeIngles.AdicionarAluno(p2);

cursoDeIngles.ListarAluno();




