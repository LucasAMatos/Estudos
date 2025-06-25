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
    public List<string> ListarTodosOsGeneros()
    {
        return new List<string>();
    }

    public List<string> ListarArtistasOrdenadamente()
    {
        return new List<string>();
    }

    public List<string> ListarTodosOsArtistasDGeneroMusical()
    {
        return new List<string>();
    }

    public List<Musica> ListarMusicasDeUmArtista()
    {
        return new List<Musica>();
    }
}