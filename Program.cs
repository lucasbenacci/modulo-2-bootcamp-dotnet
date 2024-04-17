using Modulo2_aulas.Models;
using Modulo2BootcampDotnet.Models;

//instanciando a classe Pessoa
//Não é necessário indicar o parametro, porém facilita a visualização.
Pessoa p1 = new Pessoa(nome:"Lucas", sobrenome:"Souza");
Pessoa p2 = new Pessoa(nome:"Claudio", sobrenome:"Azevedo");


//instanciando a classe Curso
Curso cursoDeIngles = new Curso();
cursoDeIngles.Nome = "Inglês";
//instanciando a lista Pessoa, criando ela vazia
cursoDeIngles.Alunos = new List<Pessoa>();

//Adicionando alunos na lista
cursoDeIngles.AdicionarAluno(p1);
cursoDeIngles.AdicionarAluno(p2);

cursoDeIngles.ListarAluno();




