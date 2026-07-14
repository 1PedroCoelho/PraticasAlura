
class Pessoa
{
    public string Nome { get; set; }
    public int Idade { get; set; }
    public Pessoa(string Nome, int Idade)
    {
        this.Nome = Nome;
        this.Idade = Idade;
    }
}
class ClienteVIP : Pessoa
{
    public string NivelFidelidade { get; set; }
    public string CodVip { get; set; }
    public ClienteVIP(string Nome, int Idade, string NivelFidelidade, string CodVip) : base(Nome, Idade)
    {
        this.NivelFidelidade = NivelFidelidade;
        this.CodVip = CodVip;
    }

    public void Exibirinformacoes()
    {
        Console.WriteLine($"Bem vindo, cliente VIP: {Nome}");
        Console.WriteLine($"Idade: {Idade}");
        Console.WriteLine($"Nível de Fidelidade: {NivelFidelidade}");
        Console.WriteLine($"Código VIP: {CodVip}");
    }
}
class Program
{
    static void Main()
    {
        ClienteVIP cliente1 = new ClienteVIP("Renata", 32, "Ouro", "VIP123A");
        ClienteVIP cliente2 = new ClienteVIP("Leonardo", 40, "Diamante", "VIP789X");

        cliente1.Exibirinformacoes();
        cliente2.Exibirinformacoes();
    }
}