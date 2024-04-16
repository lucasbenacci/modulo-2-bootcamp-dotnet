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
        
        public void AdicionarAluno(Pessoa aluno)
        {
            Alunos.Add(aluno);
        }

        public int ObterQuantidadeAlunosMatriculados()
        {
            // retorna a quantidade de alunos dentro de uma lista.
            int quantidade = Alunos.Count;
            return quantidade;
        }
    }
}