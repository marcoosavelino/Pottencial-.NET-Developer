using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Tuplas
{
    public class TuplaDados
    {
        (int, string, string, decimal) tupla = (1, "Marcos", "Avelino", 1.79M);

        public void apresentacao(){
            Console.WriteLine($"Id: {tupla.Item1}");
            Console.WriteLine($"Nome: {tupla.Item2}");
            Console.WriteLine($"Sobrenome: {tupla.Item3}");
            Console.WriteLine($"Altura: {tupla.Item4}");
        }
    }
}