using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Classe_Abstrata_e_Interface.Models
{
    public sealed class Corrente : Conta
    {
        public override void Creditar(decimal valor)
        {
            Saldo += valor;
        }
    }
}