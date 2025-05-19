using System;
using System.Collections.Generic;
using System.IO.Pipes;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ExerciciosDiversosOO
{
    class Carro
    {
        public int Velocidade { get; set; }

        public bool Buzina { get; set; }

        public string Fabricante { get; set; }

        public string Modelo { get; set; }

        private int ano;

        public int Ano
        {
            get
            {
                return ano;
            }
            set
            {
                if (value >= 1960 || value <= 2023)
                {
                    ano = value;
                }
            }
        }

        public Carro()
        {
            Velocidade = 0;
            Buzina = false;
        }
        public void Acelerar()
        {
            Velocidade++;
        }

        public void Frear()
        {
            Velocidade--;
        }

        public void Buzinar()
        {
            Buzina = true;
            Thread.Sleep(500);
            Buzina = false;
        }

        public void DescricaoDetalhada()
        {
            Console.WriteLine($"Modelo {Modelo} - Ano {Ano}");
            Console.WriteLine($"Fabricante {Fabricante}");
        }
    }
}
