using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Text.Json;
using System.Threading.Tasks;

namespace SreenSound2._0.Modelos;

internal class MusicasPreferidas
{
    public string Nome { get; set; }
    public List<Musica> ListaDeMusicasFavoristas { get; }

    public MusicasPreferidas(string nome)
    {
        Nome = nome;
        ListaDeMusicasFavoristas = new List<Musica>();
    }

    public void AdicionarMusicasFavoritas(Musica musica)
    {
        ListaDeMusicasFavoristas.Add(musica);
    }

    public void ExibirListaMusicasFavoritas()
    {
        Console.WriteLine($"{Nome} Essas são as suas músicas favoritas");
        foreach (var musica in ListaDeMusicasFavoristas)
        {
            Console.WriteLine($"- {musica.Nome} de {musica.Artista}");
        }
        Console.WriteLine();
    }

    public void GerarArquivoJson()
    {
        //objeto anonimo(temporario)
        string json = JsonSerializer.Serialize(new
        {
            nome = Nome,
            musicas = ListaDeMusicasFavoristas

        });
        string arquivoNome = $"musicas-favoritas-{Nome}.json";

        File.WriteAllText( arquivoNome, json );
        Console.WriteLine($"Arquivo json criado com sucesso {Path.GetFullPath(arquivoNome)}");
    }
}
