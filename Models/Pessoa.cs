using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Modulo2_aulas.Models
{
    public class Pessoa
    {
        //Não existe limite para ciração de tipo de construtores
        //método construtor no qual não exige os argumentos
        public Pessoa()
        {

        }

        //método construtor deve ter o mesmo nome da classe
        public Pessoa(string nome, string sobrenome)
        {

        }

        private string _nome;
        private string _sobrenome;
        private int _idade;
        public string Nome 
        { 
            get => _nome.ToUpper();
            
            set 
            {
                if(value == "" )
                {
                    throw new ArgumentException("O nome não pode ser vazio");
                }
                _nome = value;
            }
        }

        public string Sobrenome
        { 
            get => _sobrenome.ToUpper();

            set
            {
                if(value == "")
                {
                    throw new ArgumentException("O sobrenome não pode ser vazio");
                }
                _sobrenome = value;
            } 
        }
        
        public string NomeCompleto => $"{Nome} {Sobrenome}";

        public int Idade
        { 
            get =>  _idade;
            set
            {
                if(value < 0)
                {
                    throw new ArgumentException("A idade não pode ser menor que zero");
                }
                _idade = value;
            } 
        }

        public void Apresentar()
        {
            Console.WriteLine($"Nome: {NomeCompleto}, Idade: {Idade}");
        }
    }
}