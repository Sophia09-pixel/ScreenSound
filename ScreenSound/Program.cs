using System.Runtime.Intrinsics.Arm;

Banda queen = new Banda("Queen");

Album albumDoQueen = new Album("A night at the opera");

Musica musica1 = new Musica(queen, "Love of my life")
{
    Duracao = 213,
    Disponivel = true,
};

Musica musica2 = new Musica(queen, "Bohemian Rhapsody")
{
    Duracao = 354,
    Disponivel = false,
};

albumDoQueen.AdicionarMusica(musica1);
albumDoQueen.AdicionarMusica(musica2);
queen.AdicionarAlbum(albumDoQueen);

musica1.ExibirFichaTecnica();
musica2.ExibirFichaTecnica();
albumDoQueen.ExibirMusicasDoAlbum();
queen.ExibirDiscografia();

Console.WriteLine();
Podcast podcast = new Podcast("Igor","Semanal");

Episodio ep1 = new Episodio(1, "Conversa com Deadpool", "Deadpool na area");
Episodio ep2 = new Episodio(2, "Conversa com Taylor Swift", "Swift na area");

podcast.AdicionarEpisodio(ep1);
podcast.AdicionarEpisodio(ep2);

podcast.ExibirDetalhesPodcast();


