using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Excecoes_Colecoes
{
    public class Fila
    {
        public void ExemploFila(){

            Queue<int> fila = new Queue<int>();

            fila.Enqueue(2);
            fila.Enqueue(4);
            fila.Enqueue(6);
            fila.Enqueue(8);

            foreach(int item in fila){
                Console.WriteLine(item);
            }

            Console.WriteLine($"Removendo o elemento: {fila.Dequeue()}");

            foreach(int item in fila){
                Console.WriteLine(item);
            }
        }
    }
}