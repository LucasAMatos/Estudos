using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ExerciciosDiversosOO
{
    class Produto
    {
        public string Nome { get; set; }

        public string Marca { get; set; }

        public double Preco { get; set; }

        private int estoque;

        public int Estoque
        {
            get { return estoque; }
        }

        public void ExaminarEstoque()
        {
            Console.WriteLine($"Produto: {Nome}");
            Console.WriteLine($"Marca: {Marca}");
            Console.WriteLine($"Preço de Venda: {Preco}");
            Console.WriteLine($"quantidade em estoque {estoque}");
        }

        public void Retirar(int quantidade)
        {
            if (quantidade > estoque)
            {
                Console.WriteLine("Quantidade requerida maior do que a quantidade em estoque");
            }
            else
            {
                estoque -= quantidade;
            }
        }
    }
}
