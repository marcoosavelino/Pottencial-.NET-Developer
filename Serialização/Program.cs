using System;
using Serialização;
using Newtonsoft.Json;

string conteudoArquivo = File.ReadAllText("Arquivos/vendas.json");

List<Venda>? listaVenda = JsonConvert.DeserializeObject<List<Venda>>(conteudoArquivo);

foreach(Venda venda in listaVenda){
    Console.WriteLine($"Id: {venda.Id}, Produto: {venda.Produto}" + 
                      $"Preço: {venda.Preco} , Data: {venda.DataVenda.ToString("dd/MM/yyyy HH:mm")}");
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
