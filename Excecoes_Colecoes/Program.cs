using System.Globalization;

string [] linhas = File.ReadAllLines("Arquivos/aruivoLeitura.txt");

foreach(string linha in linhas){
    Console.WriteLine(linha);
}