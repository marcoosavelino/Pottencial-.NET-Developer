using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Excecoes_Colecoes
{
    public class tryCatch
    {
        public void tryCatchFinally()
        {
            try
            {
                string[] linhas = File.ReadAllLines("Arquivos/arquivo_Leitura.txt");

                foreach (string linha in linhas)
                {
                    Console.WriteLine(linha);
                }
            }
            catch (FileNotFoundException ex)
            {
                Console.WriteLine($"Ocorreu um erro na leitura do arquivo. Arquivo não encontrado! {ex.Message}");
            }
            catch (DirectoryNotFoundException ex)
            {
                Console.WriteLine($"Ocorreu um erro na leitura do arquivo. Caminho da pasta não encontrado! {ex.Message}");
            }
            catch (Exception ex)
            {
                Console.WriteLine($"Ocorreu uma exceção genérica. {ex.Message}");
            }
            finally
            {
                Console.WriteLine("Você chegou até aqui");
            }
        }
    }
}