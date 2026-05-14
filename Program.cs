using System;
class Conta
{
    public string titular;
    public int agencia;
    public int saldo;
    public int limite;

    public void ExibirInformacoes()
    {
        Console.WriteLine("Informações da conta");
        Console.WriteLine($"Nome Titular: {titular}");
        Console.WriteLine($"Número agencia: {agencia}");
        Console.WriteLine($"Saldo: {saldo}");
        Console.WriteLine($"Limite: {limite}");
    }
}
class Estoque
{
    List<Produto> produtos = new List<Produto>();
    public void AdicionarProduto(Produto x)
    {
        produtos.Add(x);
        Console.WriteLine($"Produto {x.nome} adicionado");
    }
    public void ExibirProdutos()
    {
       produtos.ForEach(produto => System.Console.WriteLine($"Produto: {produto.nome}"));
    }
}
class Produto
{
    public string nome;
    public int preco;
    public int codigo;
    public Produto(string nome, int preco, int codigo)
    {
        this.nome=nome;
        this.preco=preco;
        this.codigo=codigo;
    }
}
/*
class Program
{
    public static void Main()
    {
        Conta conta1 = new Conta();

        conta1.titular = ("Pedro");
        conta1.agencia = (123);
        conta1.saldo = (1000);
        conta1.limite = (300);

        conta1.ExibirInformacoes();

        Estoque estoque= new Estoque();

        Produto p = new Produto("Coca",10,123);
        Produto c = new Produto("pepsi",9,3223);
        Produto d = new Produto("agua",7,122343);
        estoque.AdicionarProduto(p);
        estoque.AdicionarProduto(c);
        estoque.AdicionarProduto(d);

        estoque.ExibirProdutos();
    }
}*/