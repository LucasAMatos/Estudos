using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ExerciciosDiversosOO
{
    class Conta
    {
        public Conta(Titular titular, int agencia, int numeroDaConta, double limite)
        {
            Titular = titular;
            Agencia = agencia;
            NumeroDaConta = numeroDaConta;
            Saldo = 0;
            Limite = limite;
        }

        public Titular Titular { get;  }
        public int Agencia { get;  }
        public int NumeroDaConta { get; }
        public double Saldo { get; }
        public double Limite { get; }

        public string Informacoes => $"Conta nº {this.NumeroDaConta}, Agência {this.Agencia}, Titular: {this.Titular.Nome} - Saldo: {this.Saldo}";
    }
}
