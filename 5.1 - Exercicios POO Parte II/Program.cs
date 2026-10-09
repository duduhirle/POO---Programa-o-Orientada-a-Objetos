using _5._1___Exercicios_POO_Parte_II;
using Microsoft.VisualBasic;


Console.WriteLine("-=-=-=-=- Exercicio 1 -=-=-=-=-");
Pessoa ana = new Pessoa();
ana.Nome = "Ana";

ana.Cumprimentar();
ana.CumprimentarAlguem("Bruno");

string frase = ana.ObterApresentacao();
Console.WriteLine(frase);



Console.WriteLine("-=-=-=-=- Exercicio 2 -=-=-=-=-");
Calculadora calc = new Calculadora();

int soma = calc.Somar(10, 5);
calc.MostrarResultado(soma);

calc.MostrarResultado(calc.Subtrair(10, 5));


Console.WriteLine("-=-=-=-=- Exercicio 3 -=-=-=-=-");
Temperatura conv = new Temperatura();

double f = conv.CelsiusParaFahrenheit(25);
Console.WriteLine($"25°C = {f}°F");

if (conv.EstaQuente(35))
{
    Console.WriteLine("35°C: está quente!");
}

if (!conv.EstaQuente(18))
{
    Console.WriteLine("18°C: não está quente.");

}




Console.WriteLine("-=-=-=-=- Exercicio 4 -=-=-=-=-");


Cofrinho cofre = new Cofrinho("Ana");

cofre.Guardar(50);
cofre.Guardar(-10);
cofre.Guardar(30);

if (cofre.Retirar(100))
    Console.WriteLine("Retirada feita!");
else
    Console.WriteLine("Saldo insuficiente.");

if (cofre.Retirar(20))
    Console.WriteLine("Retirada feita!");
else
    Console.WriteLine("Saldo insuficiente.");

Console.WriteLine($"Saldo: R$ {cofre.Saldo:F2}");
Console.WriteLine($"Faltam R$ {cofre.FaltaParaMeta(200):F2} para a meta.");
