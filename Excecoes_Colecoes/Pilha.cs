using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Excecoes_Colecoes
{
    public class Pilha
    {
        public void ExemploPilha(){

            Stack<int> pilha = new Stack<int>();

            pilha.Push(4);
            pilha.Push(6);
            pilha.Push(8);
            pilha.Push(10);

            foreach(int item in pilha){
                Console.WriteLine(item);
            }

            Console.WriteLine($"Removendo o elemento do topo: {pilha.Pop()}");

            foreach(int item in pilha){
                Console.WriteLine(item);
            }
        }
    }
}