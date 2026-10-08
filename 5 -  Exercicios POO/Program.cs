using _5___POO;

Console.WriteLine("-=-=-=-Exercicio 1-=-=-=-");

Pessoa p1 = new Pessoa();
Console.WriteLine("Qual seu nome?");
p1.Nome = Console.ReadLine();
Console.WriteLine("Quantos anos voce tem?");
p1.Idade = int.Parse(Console.ReadLine());

p1.Apresentar();

Pessoa p2 = new Pessoa();
Console.WriteLine("Qual seu nome?");
p2.Nome = Console.ReadLine();
Console.WriteLine("Quantos anos voce tem?");
p2.Idade = int.Parse(Console.ReadLine());

p2.Apresentar();



Console.WriteLine("-=-=-=-Exercicio 2-=-=-=-");
retangulo ret = new retangulo();
Console.WriteLine("Qual é a Largua?");
ret.Largura = double.Parse(Console.ReadLine());
Console.WriteLine("Qual é a Altura?");
ret.Altura = double.Parse(Console.ReadLine());

Console.WriteLine($"Área:{ret.Area()} e Perímetro:{ret.Perimetro()}");



Console.WriteLine("-=-=-=-Exercicio 3-=-=-=-");
lampada lampada = new lampada();

lampada.ExibirEstado();
lampada.Ligar();
lampada.ExibirEstado();
lampada.Alternar();
lampada.ExibirEstado();




Console.WriteLine("-=-=-=-Exercicio 4-=-=-=-");
banco Banco = new banco();

Console.WriteLine("Quem é o titular, nome completo sem abreviacao");
Banco.Titular = Console.ReadLine();

Console.WriteLine("Saldo Presente");
Banco.Saldo = double.Parse(Console.ReadLine());

Console.WriteLine("Quanto você quer depositar?");
Banco.Depositar = double.Parse(Console.ReadLine());