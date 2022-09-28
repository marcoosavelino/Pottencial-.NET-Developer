using System;
using Serialização;
using Newtonsoft.Json;

string conteudoArquivo = File.ReadAllText("Arquivos/vendas.json");

List<Venda> listaVenda = JsonConvert.DeserializeObject<List<Venda>>(conteudoArquivo);

var tipoAnonimo = listaVenda.Select(x => new {x.Produto, x.Preco, x.DataVenda} );

foreach (var venda in tipoAnonimo){
    Console.WriteLine($"Preço: {venda.Produto} / Preço: {venda.Preco} / Data da Venda: {venda.DataVenda}");
}








// SERIALIZAÇÃO JSON
/*
DateTime DataAtual = DateTime.Now;

List<Venda> listaVendas = new List<Venda>();

Venda v1 = new Venda(1, "Material de Escritório", 25.00M, DataAtual);
Venda v2 = new Venda(2, "Licença de Software", 110.00M, DataAtual);

listaVendas.Add(v1);
listaVendas.Add(v2);

string serializado = JsonConvert.SerializeObject(listaVendas, Formatting.Indented);

File.WriteAllText("Arquivos/vendas.json", serializado);

Console.WriteLine(serializado);
*/
