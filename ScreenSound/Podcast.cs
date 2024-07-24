class Podcast
{
    private List<Episodio> listaEpisodios = new List<Episodio>();
    public string Host { get; }
    public string Nome { get; }
    public int TotalEpisodios { get; set; }

    public Podcast( string host, string nome)
    {
        this.Host = host;
        this.Nome = nome;
        
    }

    public void AdicionarEpisodio(Episodio episodio)
    {
        TotalEpisodios++;
        listaEpisodios.Add(episodio);
    }

    public void ExibirDetalhesPodcast()
    {
        Console.WriteLine($"Detalhes do poscast {Nome} apresentado por {Host}");
        Console.WriteLine($"Total Episodios {TotalEpisodios}");
        foreach (var episodios in listaEpisodios.OrderBy(e => e.Ordem))
        {
            Console.WriteLine($"Episodio: {episodios.Ordem} - Titulo: {episodios.Titulo}");
        }
    }
}