using ScreenSound.Models;
using System.Text.Json;

HttpClient client = new HttpClient();

string resposta = await client.GetStringAsync("https://guilhermeonrails.github.io/api-csharp-songs/songs.json");
var musicas = JsonSerializer.Deserialize<Musicas>(resposta);

foreach (Musica musica in musicas.ListarMusicasDeUmArtista("U2"))
{
    Console.WriteLine($"{musica.Nome}");
}
