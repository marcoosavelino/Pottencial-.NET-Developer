using Classe_Abstrata_e_Interface.Models;
using Classe_Abstrata_e_Interface.interfaces;

Corrente conta = new Corrente();
conta.Creditar(500);
conta.ExibirSaldo();

ICalculadora calc = new Calculadora();
int num1 = 9;
int num2 = 3;
Console.WriteLine($"{num1} * {num2} = {calc.Multiplicar(num1,num2)}");
Console.WriteLine($"{num1} / {num2} = {calc.Dividir(num1,num2)}");
Console.WriteLine($"{num1} + {num2} = {calc.Somar(num1,num2)}");
Console.WriteLine($"{num1} - {num2} = {calc.Subtrair(num1,num2)}");
