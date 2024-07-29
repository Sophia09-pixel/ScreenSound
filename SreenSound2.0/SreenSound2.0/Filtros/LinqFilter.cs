using SreenSound2._0.Modelos;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SreenSound2._0.Filtros;

internal class LinqFilter
{
   public static void FiltrarGenerosMusicais(List<Musica> musicas)
    {
        var generosMusicas = musicas.Select(generos => generos.Genero).Distinct().ToList();

        foreach (var genero in generosMusicas)
        {
            Console.WriteLine($"- {genero}");
        }
    }

    public static void FiltrarArtistaPorGeneroMusical(List<Musica> musicas, string genero)
    {
        var artistasPorGeneroMusical = musicas.Where(musica => musica.Genero!.Contains(genero)).Select(musica => musica.Artista).Distinct().ToList();

        Console.WriteLine($"Exibindo os artistas por genero musical {genero}");

        foreach (var artista in artistasPorGeneroMusical)
        {
            Console.WriteLine($"- {artista}");
        }
    }

    public static void FiltrarMusicasArtista(List<Musica> musicas, string artista)
    {
        var musciasDoArtista = musicas.Where(musica => musica.Artista!.Equals(artista));

        Console.WriteLine(artista);
        foreach (var musica in musciasDoArtista)
        {
            Console.WriteLine($"- {musica.Nome}");
        }
    }

}
