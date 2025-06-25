using ScreenSound.Models;

var MeuPersonagem = Personagem_GOT.CarregarPersonagemPorID(16).Result;

Console.WriteLine(MeuPersonagem.Nome);