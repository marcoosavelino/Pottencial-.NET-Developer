using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Fundamentos
{
    internal class Pessoa
    {
        public int Idade { get; set; }
        public string Nome { get; set; }

        public void Apresentar()
        {
            Console.WriteLine("Olá, meu nome é " + Nome + ", tenho " + Idade + " anos.");
        }
    }
}
