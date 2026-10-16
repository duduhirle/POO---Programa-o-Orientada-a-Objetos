using FundamentosPOO.PilaresPOO.Heranca;
using Heranca.ExerciciosHeranca.Exercicio_2;
using Heranca.ExerciciosHeranca.Exercicio1;
using Heranca.ExerciciosHeranca.Exercicio3;

Aluno aluno = new Aluno();

aluno.Idade = 20;
aluno.Nome = "Vinicio";

aluno.Apresentar();


Console.WriteLine("-=-=-=-=-= Exercicio 1 -=-=-=-=-="); 
Cachorro cachorro = new Cachorro();
cachorro.Nome = "Rex";

cachorro.Comer();
cachorro.Latir();




Console.WriteLine("-=-=-=-=-= Exercicio 2 -=-=-=-=-=");
Funcionario ana = new Funcionario("Ana", 3000);
Gerente carlos = new Gerente("Carlos", 5000, 1500);

Console.WriteLine($"{ana.Nome}: R$ {ana.Salario:F2}");
Console.WriteLine($"{carlos.Nome}: R$ {carlos.Salario:F2} + bônus = R$ {carlos.SalarioComBonus():F2}");






Console.WriteLine("-=-=-=-=-= Exercicio 3 -=-=-=-=-=");
Carro carro = new Carro("Fiat", "Uno", 4);
Moto moto = new Moto("Honda", "CG 160", 160);

carro.Exibir();
carro.ExibirPortas();

moto.Exibir();
moto.ExibirCilindradas();