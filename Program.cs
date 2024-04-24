using Modulo2_aulas.Models;
using Modulo2BootcampDotnet.Models;
using System.Data;

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

Console.WriteLine("Utilizando Queue (Fila)");
Console.WriteLine(" ");
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

Console.WriteLine(" ");
//Retira o primeiro elemento da fila (FIFO funcionando)
Console.WriteLine($"Proxima lista estou retirando o primeiro elemento: {f.Dequeue()}");

foreach(int i in f)
{
    Console.WriteLine(i);
}

Console.WriteLine("---------------------------------------");

Console.WriteLine("Utilizando Stack (Pilha)");
Console.WriteLine(" ");
//A stack funciona como LIFO (Last in first out)
//como inicializar a stack
Stack<int> p = new Stack<int>();
//adicionando valores na stack
p.Push(2);
p.Push(3);
p.Push(8);
p.Push(5);

foreach(int i in p)
{
    Console.WriteLine(i);
}

Console.WriteLine(" ");
Console.WriteLine($"Próxima lista estou retirando o elemento da minha stack: {p.Pop()}");

foreach(int i in p)
{
    Console.WriteLine(i);
}

Console.WriteLine("---------------------------------------");

Console.WriteLine("Implementando um dictionary: ");
Console.WriteLine(" ");

//Implementando o dictionary, o primeiro valor é a chave e o segundo valor, é o valor referente a chave em questão
Dictionary<string, string> estados = new Dictionary<string, string>();
estados.Add("SP", "São Paulo");
estados.Add("BA", "Bahia");
estados.Add("MG", "Minas Gerais");

foreach(var item in estados)
{
    Console.WriteLine($"Chave: {item.Key} Valor: {item.Value}");
}

//Removendo um valor do meu dictionary
estados.Remove("BA");

//Alterando um valor do meu dictionary, o valor da key não pode ser alterado
estados["SP"] = "São Paulo - Valor Alterado";

Console.WriteLine(" ");
foreach(var item in estados)
{
    Console.WriteLine($"Chave: {item.Key} Valor: {item.Value}");
}

//verificando se a chave já esta cadastrada
string chave = "BA";
Console.WriteLine("Verificando o elemento");
if (estados.ContainsKey(chave))
{
    Console.WriteLine("Valor existente");
}else
{
    Console.WriteLine($"Não existe, o valor {chave} pode se inserido");
}

Console.WriteLine(" ");
//buscando um valor utilizando a key
Console.WriteLine(estados["SP"]);

Console.WriteLine("---------------------------------------");

//Implementando uma Tupla
(int, string, string, decimal) t = (1, "Lucas", "Souza", 1.83M);
ValueTuple<int, string, string, decimal> t2 = (2, "Gabriel", "Borges", 1.75M);
var t3 = Tuple.Create(3, "Fabricio", "Neves", 1.64M);

//Como exibir os itens da minha Tupla
Console.WriteLine($"ID: {t.Item1}");
Console.WriteLine($"Nome: {t.Item2}");
Console.WriteLine($"Sobrenome: {t.Item3}");
Console.WriteLine($"Altura: {t.Item4}");

Console.WriteLine(" ");
Console.WriteLine("Outro Usuário: ");
Console.WriteLine($"ID: {t2.Item1}");
Console.WriteLine($"Nome: {t2.Item2}");
Console.WriteLine($"Sobrenome: {t2.Item3}");
Console.WriteLine($"Altura: {t2.Item4}");

Console.WriteLine(" ");
Console.WriteLine("Outro Usuário: ");
Console.WriteLine($"ID: {t3.Item1}");
Console.WriteLine($"Nome: {t3.Item2}");
Console.WriteLine($"Sobrenome: {t3.Item3}");
Console.WriteLine($"Altura: {t3.Item4}");

Console.WriteLine("---------------------------------------");

//instanciando a minha classe leitura arquivo
LeituraArquivo arquivo = new LeituraArquivo();

//guardando os valores retornados pela classe em uma tupla
var (Sucesso, Linhas, quantidadeLinhas)  = arquivo.LerArquivo("Files/arquivoLeitura.txt");

if(Sucesso)
{
    Console.WriteLine("Quantidade de linhas do arquivo:" + quantidadeLinhas);
    foreach(string linha in Linhas)
    {
        Console.WriteLine(linha);
    }
}else
{
    Console.WriteLine("Não foi possível ler o arquivo!");
}

Console.WriteLine("---------------------------------------");

Pessoa pn = new Pessoa("Miguel", "Borger");
(string nome, string sobrenome) = pn;

Console.WriteLine($"{nome} {sobrenome}");

Console.WriteLine("---------------------------------------");

int n = 52;
bool par = false;

//if ternário
par = n % 2 == 0;
Console.WriteLine($"O Número {n} é " + (par ? "par" : "impar"));