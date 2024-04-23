using Modulo2_aulas.Models;
using Modulo2BootcampDotnet.Models;
//Troco a cultura do sistema para a localização desejada.
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
//formatando para uma cultura especifica
Console.WriteLine(valorMonetario.ToString("C", CultureInfo.CreateSpecificCulture("pt-br")));

Console.WriteLine("---------------------------------------");

double pc = .3521;

Console.WriteLine(pc.ToString("P"));

Console.WriteLine("---------------------------------------");

string dataString = "2022-04-17 18:00";
DateTime.TryParseExact(dataString, "yyyy-MM-dd HH:mm", CultureInfo.InvariantCulture, DateTimeStyles.None, out DateTime data);

Console.WriteLine(data.ToString("dd/MM/yyyy HH:mm"));
Console.WriteLine(data.ToShortDateString());
Console.WriteLine(data.ToShortTimeString());

Console.WriteLine("---------------------------------------");

try{
    //Posibilita a leita de arquivos externos.
    string[] linhas = File.ReadAllLines("Files/arquivoLeitura.txt");

    foreach(string linha in linhas)
    {
        Console.WriteLine(linha);
    }
//Pode-se utilizar quantos catchs forem necessários, relacionados a cada exception retornado por cada método.
} catch (DirectoryNotFoundException e )
{
    Console.WriteLine($"Aqui deu merda! O diretório não foi encontrato. {e.Message}");
} catch (FileNotFoundException e) 
{
    Console.WriteLine($"Aqui deu merda! O arquivo não foi encontrado. {e.Message}");
} finally 
{
    Console.WriteLine("Chegou até aqui!");
}

Console.WriteLine("---------------------------------------");

//como inicializar a fila
//A fila funciona com FIFO (first in first out)
Queue<int> f = new Queue<int>();

//como adicionar valores na minha fila
f.Enqueue(2);
f.Enqueue(5);
f.Enqueue(8);
f.Enqueue(1);

foreach(int i in f)
{
    Console.WriteLine(i);
}

//Retira o primeiro elemento da fila (FIFO funcionando)
Console.WriteLine($"Proxima lista estou retirando o primeiro elemento: {f.Dequeue()}");

foreach(int i in f)
{
    Console.WriteLine(i);
}

Console.WriteLine("---------------------------------------");
