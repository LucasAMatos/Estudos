using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ExerciciosDiversosOO
{
    public class Jogo
    {
        public string Nome { get; }

        public string FaixaEtaria { get; }

        public string Genero { get; }

        public int Jogadores { get; }

        public string Plataforma { get; }

        public Jogo(string nome, string faixaEtaria, string gênero, int jogadores, string plataforma)
        {
            Nome = nome;
            FaixaEtaria = faixaEtaria;
            Genero = gênero;
            Jogadores = jogadores;
            Plataforma = plataforma;
        }
    }
}
