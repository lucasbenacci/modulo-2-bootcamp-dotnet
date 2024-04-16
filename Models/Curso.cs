using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Modulo2_aulas.Models;

namespace Modulo2BootcampDotnet.Models
{
    public class Curso
    {
        public string Nome { get; set; }
        public List<Pessoa> Alunos { get; set; }
        
        //tipo do método void não gera nenhum tipo de retorno
        public void AdicionarAluno(Pessoa aluno)
        {
            //adiciona o aluno na lista Pessoa 
            Alunos.Add(aluno);
        }

        //tipo do método int retorna um inteiro (poderia ser de qualquer tipo)
        public int ObterQuantidadeAlunosMatriculados()
        {
            // retorna a quantidade de alunos dentro de uma lista.
            int quantidade = Alunos.Count;
            return quantidade;
        }

        public bool RemoverAluno(Pessoa aluno)
        {
            //O remove gera um return do tipo boleano, sendo assim utilizamos ele para o retorno do método. 
            return Alunos.Remove(aluno);
        }

        public void ListarAluno()
        {
            Console.WriteLine($"Alunos do curso {Nome}");
            foreach (Pessoa aluno in Alunos)
            {
                Console.WriteLine(aluno.NomeCompleto);
            }
        }
    }
}