using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Modulo2BootcampDotnet.Models
{
    public class LeituraArquivo
    {
        public (bool Sucesso, string[] Linhas, int quantidadeLinhas) LerArquivo(string caminho)
        {
            try
            {
                string[] Linhas = File.ReadAllLines(caminho);
                return(true, Linhas, Linhas.Count());
            }catch(Exception)
            {
                return(false, new string[0], 0);
            }
        }
    }
}