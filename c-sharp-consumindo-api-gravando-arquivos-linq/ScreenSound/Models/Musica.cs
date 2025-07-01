using System.Text.Json.Serialization;

namespace ScreenSound.Models;

internal class Musica
{
    [JsonPropertyName("song")]
    public string Nome;
    
    [JsonPropertyName("artist")]
    public string Artista { get; set; }

    [JsonPropertyName("duration_ms")]
    public int Duracao { get; set; }

    [JsonPropertyName("genre")]
    public string? Genero { get; set; }

    public void ExibirDetalhesDaMusica()
    {
        Console.WriteLine($"Nome {Nome}");
        Console.WriteLine($"Artista {Artista}");
    }
}

internal class Musicas : List<Musica> {
    public List<string> ListarTodosOsGenerosMusicais() => this.Select(static generos => generos.Genero).Distinct().ToList();

    public List<string> ListarArtistasOrdenadamente() => this.OrderBy(m => m.Artista).Select(m => m.Artista).Distinct().ToList();

    public List<string> ListarTodosOsArtistasDGeneroMusical(string genero) => this.Where(musicas => genero.Contains(genero)).Select(musica => musica.Artista).Distinct().ToList();

    public List<Musica> ListarMusicasDeUmArtista(string artista) => this.Where(musica => musica.Artista.Equals(artista)).ToList();
}