using ExerciciosEncapsulamento.Exercicio1;



Console.WriteLine("-=-=-=-= Exercicio 1 =-=-=-=-");
/* ### 👀 Exercício 1: Contador de Visitas

Crie a classe `ContadorDeVisitas` com:

- Campo `private int visitas` (ninguém de fora pode mexer).
- Método público `RegistrarVisita()`: soma 1 às visitas.
- Método público `ObterTotal()`: **retorna** o total de visitas.
 * 
 * 
 * 
 */


Contador contador = new Contador();

contador.RegristrarVisita();
contador.RegristrarVisita();
contador.RegristrarVisita();

Console.WriteLine($"Total de visitas: {contador.ObterTotal()}");



Console.WriteLine("-=-=-=-= Exercicio 2 =-=-=-=-");
/* - Propriedade pública `Aluno`: `public string Aluno { get; set; }`
- Campo `private double nota`.
- Método público `DefinirNota(double valor)`: só aceita notas de 0 a 10. Fora disso, mostra "Nota inválida: {valor}" e não altera a nota.
- Método público `ObterNota()`: **retorna** a nota. */

Boletim boletim = new Boletim();
boletim.Aluno = "Ana";

boletim.DefinirNota(8.5);
boletim.DefinirNota(15);

Console.WriteLine($"{boletim.Aluno}: nota {boletim.ObterNota()}");