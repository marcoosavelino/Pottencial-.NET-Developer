using System;
using Tuplas;

// IF Ternário
int numero = 15;
Console.WriteLine($"O número {numero} é: " + (numero % 2 == 0 ? "Par" : "Ímpar"));


// Tupla e Exception
//ExceptionTupla exemplo1 = new ExceptionTupla();
//Console.WriteLine(exemplo1.LerArquivo("Arquivos/arquivoLeitura.txt"));


//Utilizando classe e método:

//TuplaDados tupla1 = new TuplaDados();
//tupla1.apresentacao();

// Outros exemplos de tupla

/*
ValueTuple<int, string, string, decimal> outroExemploTupla = (1, "Marcos", "Avelino", 1.79M);
var outroExemploTuplaCreate = Tuple.Create(1, "Marcos Miguel", "Avelino", 1.79M);

Console.WriteLine($"Id: {outroExemploTupla.Item1}");
Console.WriteLine($"Nome: {outroExemploTupla.Item2}");
Console.WriteLine($"Sobrenome: {outroExemploTupla.Item3}");
Console.WriteLine($"Altura: {outroExemploTupla.Item4}");
*/