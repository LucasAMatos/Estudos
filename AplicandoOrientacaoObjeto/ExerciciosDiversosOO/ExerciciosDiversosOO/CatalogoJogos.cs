using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ExerciciosDiversosOO
{
    public class CatalogoJogos
    {
        public string Nome { get; }

        public List<Jogo> JogosDisponiveis { get; }

        public CatalogoJogos(string nome)
        {
            Nome = nome;
            JogosDisponiveis = new List<Jogo>();
        }

        public void AdicionarJogo(Jogo nome)
        {
            JogosDisponiveis.Add(nome);
        }

        public void ExibirCatalogo()
        {
            Console.WriteLine($"lista de jogos disponíveis no catálogo {Nome}");
            foreach (Jogo jogo in JogosDisponiveis)
            {
                Console.WriteLine($"{jogo.Nome} Gênero: {jogo.Genero}");
            }
        }
    }
}
