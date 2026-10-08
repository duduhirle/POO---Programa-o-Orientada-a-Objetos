/*  ----------------------- Palavras Chave -----------------------
Objetos: Instancia de uma classe (instanciar)
Classes: Modelo para criar objetos, possui atributos e metodos  | O que ele vai ser o que?
Atributos: Caracteristicas do objeto - EX: sabor,cor e tamanho do bolo
Métodos: Ações que o objeto pode realizar - EX: cortar,assar e decorar o bolo
 

1. Sempre comeca com    public class Nome_da_classe
2. Definir atributo 
    public tipo Nome
 3. Definir metodos
    public retorno Nome()
 */

using FundamentosPOO;


// Instanciar

Carro carroDoDudu = new Carro();

carroDoDudu.Marca = "Chevrollet";
carroDoDudu.Modelo = "Tauros";
carroDoDudu.Ano = 2026;
carroDoDudu.ExibirInformacoes();


Console.WriteLine("-=-=-=-=-=-=-=-=-=-=-=-=-");

// Instanciem um novo objeto
Carro chevetao = new Carro();
chevetao.Marca = "Chevete";
chevetao.Modelo = "Chevetin";
chevetao.Ano = 1998;
chevetao.ExibirInformacoes(); 

Console.WriteLine("-=-=-=-=-=-=-=-=-=-=-=-=-");

// Classe Pedido 
// NomeDoPedido, Item , Quantidade, Preco

Pedido pedidos = new Pedido();
pedidos.NomeDoCliente = "Eduardo";
pedidos.Item = "Borrachas";
pedidos.Quantidade = 50;
pedidos.Preco = 200.50;
pedidos.ExibirInfo();