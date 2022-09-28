using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Classe_Abstrata_e_Interface.Models
{
    public abstract class Conta
    {
        protected decimal Saldo;

        public abstract void Creditar(decimal valor);

        public void ExibirSaldo(){
            Console.WriteLine($"O seu saldo é: {Saldo}");
        }
    }
}