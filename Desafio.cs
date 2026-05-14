class Podcast
{
    List<Episodio> Episodios = new List<Episodio>();
    public string Host { get; }
    public string Nome { get; set; }
    public int TotalEpisodios { get { return Episodios.Count; } }


    public void AdicionarEpisodios(Episodio episodio) => Episodios.Add(episodio);
    public void ExibirDetalhes()
    {
        System.Console.WriteLine($"Nome do Podcat: {Nome}");
        System.Console.WriteLine($"Host do Podcat: {Host}");
        System.Console.WriteLine($"Total episódios do Podcat: {TotalEpisodios}");
    }
    public Podcast(string Host, string Nome)
    {
        this.Host = Host;
        this.Nome = Nome;
    }
}
class Episodio
{
    List<string> convidados = new List<string>();
    public int duracao;
    public int ordem;
    public string Resumo => $"Número:{ordem} | Título: {titulo} |Duração: {duracao} | Convidados {string.Join(", ", convidados)} ";
    //numero, titulo, duraçao e resumo
    public string titulo;
    public Episodio(int ordem, int duracao, string titulo)
    {
       this.ordem= ordem;
       this.duracao= duracao;
       this.titulo= titulo;
    }

    public void AdicionarConvidados(string nome)
    {
        convidados.Add(nome);
    }
}
class Program
{
    static void Main()
    {
        Episodio ep1 = new(1, 45,"Pedro1");
        ep1.AdicionarConvidados("Sara");
        System.Console.WriteLine(ep1.Resumo); 
        Podcast P = new Podcast("Pedro", "Pedrocast");
        
    }
}