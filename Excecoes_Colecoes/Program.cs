using System.Globalization;
using Excecoes_Colecoes;

Dictionary<string, string> estados = new Dictionary<string, string>();

estados.Add("SP", "São Paulo");
estados.Add("BA", "Bahia");
estados.Add("MG", "Minas Gerais");

foreach(var item in estados){
    Console.WriteLine($"Chave: {item.Key} , Valor: {item.Value}");
}

Console.WriteLine("-------------");

estados.Remove("BA");
estados["SP"] = "São Paulo - Valor alterado!";


foreach(var item in estados){
    Console.WriteLine($"Chave: {item.Key} , Valor: {item.Value}");
}

Console.WriteLine("-------------");

Console.WriteLine(estados["MG"]);

/*
Fila ExFila = new Fila();
ExFila.ExemploFila();
*/

/*
Pilha ExPilha = new Pilha();
ExPilha.ExemploPilha();
*/

// new ExemploExcecao().Metodo1();

/*
tryCatch exemplo = new tryCatch();
exemplo.tryCatchFinally();
*/