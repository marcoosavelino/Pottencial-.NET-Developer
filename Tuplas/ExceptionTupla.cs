using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Tuplas
{
    public class ExceptionTupla
    {
        public (bool Sucesso, int QuantidadeLinhas) LerArquivo(string caminho){
            try{
                string[] linhas = File.ReadAllLines(caminho);

                foreach(string linha in linhas){
                    Console.WriteLine(linha);
                }

                return (true, linhas.Count());
            }
            catch (Exception){
                
                Console.WriteLine("Não foi possível ler o arquivo!");
                return (false, 0);
            }
        }
    }
}