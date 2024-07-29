using SreenSound2._0.Modelos;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SreenSound2._0.Filtros;

internal class LinqOrder
{
    public static void ExibirArtistasOrdenados(List<Musica> musicas)
    {
        var nomeArtistas = musicas.OrderBy(artista => artista.Artista).Select(artista => artista.Artista).Distinct().ToList();

        Console.WriteLine("Lista de artistas ordenados");
        foreach (var artista in nomeArtistas)
        {
            Console.WriteLine($"- {artista}");
        }

    }
}
