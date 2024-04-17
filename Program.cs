using Modulo2_aulas.Models;
using Modulo2BootcampDotnet.Models;
//Troco a configuração do sistema para a localização desejada.
using System.Globalization;
CultureInfo.DefaultThreadCurrentCulture = new CultureInfo("en-us");

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

Console.WriteLine("---------------------------------------");

string n1 = "10";
string n2 = "20";

string result = n1 + n2;

Console.WriteLine(result);

Console.WriteLine("---------------------------------------");

decimal valorMonetario = 82.40M;

//:C formata de acordo com a configuração local, c = currency 
Console.WriteLine($"{valorMonetario:C}");


