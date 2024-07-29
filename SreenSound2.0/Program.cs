using ScreenSound_04.Modelos;
using System.Text.Json;
using ScreenSound_04.Filtros;

using (HttpClient client = new HttpClient())
{
    try
    {
        string resposta = await client.GetStringAsync("https://guilhermeonrails.github.io/api-csharp-songs/songs.json");
        var musicas = JsonSerializer.Deserialize<List<Musica>>(resposta)!;

        musicas[4].ExibirDetalhesDaMusica();
        Console.WriteLine();



        Console.WriteLine(musicas.Count);

        LinqFilter.FiltrarGenerosMusicais(musicas);

        LinqOrder.ExibirArtistasOrdenados(musicas);

        LinqFilter.FiltrarArtistaPorGeneroMusical(musicas, "pop");

        LinqFilter.FiltrarMusicasArtista(musicas, "Taylor Swift");

        var musicasPreferidas = new MusicasPreferidas("Sophia");

        for (int i = 0; i < 5; i++)
        {
            musicasPreferidas.AdicionarMusicasFavoritas(musicas[i]);
        }

        musicasPreferidas.ExibirListaMusicasFavoritas();

        //musicasPreferidas.GerarArquivoJson();

        var musicasPreferidas2 = new MusicasPreferidas("Minguel");

        for (int i = 5; i < 10; i++)
        {
            musicasPreferidas2.AdicionarMusicasFavoritas(musicas[i]);
        }

        musicasPreferidas2.ExibirListaMusicasFavoritas();


        LinqFilter.FiltrarMusicasEmCSharp(musicas);


    }
    catch (Exception ex)
    {
        Console.WriteLine($"Erro ao requisitar - {ex.Message}");
    }

    //try
    //{
    //    using (HttpClient shark = new HttpClient())
    //    {
    //        string resposta = await shark.GetStringAsync("https://www.cheapshark.com/api/1.0/deals");
    //        Console.WriteLine(resposta);
    //    }
    //}catch (Exception ex)
    //{
    //    Console.WriteLine(ex.Message);
    //}
}