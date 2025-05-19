using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ExerciciosDiversosOO
{
    class ContaBancaria
    {
        public int Numero { get; set; }

        public string Titular { get; set; }

        public double Saldo { get; set; }

        public string Senha { get; set; }

        public void ExibirInformacoes()
        {
            Console.WriteLine($"Conta número: {Numero}");
            Console.WriteLine($"Titular da conta: {Titular}");
            Console.WriteLine($"Saldo: {Saldo}");
        }
        public int Somar(int a, int b) => a + b;
    }
}
