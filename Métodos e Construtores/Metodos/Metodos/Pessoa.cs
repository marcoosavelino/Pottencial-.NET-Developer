using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Metodos
{
    internal class Pessoa
    {
        private string _nome;
        private int _idade;

        public Pessoa()
        {

        }
        public Pessoa(string Nome, int Idade)
        {
            this.Nome = Nome;
            this.Idade = Idade;
        }

        public void Descontruct(out string nome, out int idade){
            nome = this.Nome;
            idade = this.Idade;
        }
        public string Nome {
            get
            {
                return _nome.ToUpper();
            }

            set
            {
                if(value == "")
                {
                    throw new ArgumentException("O valor não pode ser vazio!");
                }
               
                _nome = value;
            } 
        }
        public int Idade {
            get
            {
                return _idade;
            }
            set 
            {
                if (value < 0)
                {
                    throw new ArgumentException("O valor não pode ser negativo!");
                }

                _idade = value;
            }
        }

        public string Sobrenome { get; set; }
        public string NomeCompleto => $"{Nome} {Sobrenome}".ToUpper();

        public void Apresentar()
        {
            Console.WriteLine($"Meu nome é {NomeCompleto}, tenho {Idade} anos.");
        }
    }
}
