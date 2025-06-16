namespace PraticandoCSharp
{
    class ExercisesIfElse
    {
        public static void Exemplo1()
        {
            bool conexaoAtiva = false;

            if (conexaoAtiva)
            {
                Console.WriteLine("Iniciando o jogo!");
            }
            else
            {
                Console.WriteLine("Você perdeu sua conexão");
            }
        }

        public static void Exemplo2()
        {
            double valorCompra = 245.00;
            bool clienteVip = false;

            if (valorCompra > 300 || clienteVip)
            {
                double desconto = valorCompra * 0.1;
                Console.WriteLine($"Você ganhou {desconto} reais em desconto!");
            }
            else if (valorCompra > 200)
            {
                Console.WriteLine("Parabéns! você ganhou um brinde!");
            }
            else
            {
                double diferenca = 300 - valorCompra;
                Console.WriteLine($"Faça mais {diferenca} reais em compra para ganhar 10% de desconto");
            }
        }

        public static void Ex1() //Verificando o saldo da conta
        {
            Console.WriteLine("Digite o saldo:");
            
            string valor = Console.ReadLine();
            double valorDouble = double.Parse(valor);

            if (valorDouble > 0.0)
            {
                Console.WriteLine("O saldo está positivo");
            }
            else if (valorDouble < 0.0)
            {
                Console.WriteLine("O saldo está negativo");
            }
            else
            {
                Console.WriteLine("O saldo está zerado");
            }
        }

        public static void Ex2() //Classificação de produtos
        {
            Console.Write("Digite o código do produto (1 ou 2):");

            string valor = Console.ReadLine();

            if (valor == "1")
            {
                Console.WriteLine("Perecível");
            }
            else if (valor == "2")
            {
                Console.WriteLine("Não Perecível");
            }
            else 
            {
                Console.WriteLine("Código digitado é inválido");
            }
        }

        public static void Ex3() //Classificando a nota de um aluno
        {
            Console.WriteLine("Informe a nota final do aluno:");

            string valor = Console.ReadLine();
            double valorDouble = double.Parse(valor);

            string nota = string.Empty;
            if (valorDouble >= 9.0)
                nota = "A";
            else if (valorDouble >= 7)
                nota = "B";
            else if (valorDouble >= 5)
                nota = "C";
            else
                nota = "D";

                Console.WriteLine($"O aluno recebeu a nota {nota}");
        }

        public static void Ex4() //Verificando acesso a área restrita
        {
            Console.WriteLine("Digite a senha:");
            string senha = Console.ReadLine();
            
            Console.WriteLine("Digite o nível de acesso:");
            string nivel = Console.ReadLine();
            int nivelInteiro = int.Parse(nivel);

            if (senha == "42" && nivelInteiro >= 5)
            {
                Console.WriteLine("Acesso Liberado.");
            }
            else
            {
                Console.WriteLine("Acesso Negado.");
            }
        }

        public static void Ex5() //Classificando a faixa etária
        {
            Console.WriteLine("Digite a idade:");
            string idade = Console.ReadLine();
            int idadeInt = int.Parse(idade);

            string classificacao = string.Empty;
            if (idadeInt <= 12)
            {
                classificacao = "infantil";
            }
            else if (idadeInt <= 17)
            {
                classificacao = "adolescente";
            }
            else if (idadeInt <= 59)
            {
                classificacao = "adulto";
            }
            else
            {
                classificacao = "idoso";
            }

            Console.WriteLine($"Classificação: {classificacao}");
        }
    }

}
