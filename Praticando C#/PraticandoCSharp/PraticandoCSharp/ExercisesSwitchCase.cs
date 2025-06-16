namespace PraticandoCSharp
{
    class ExercisesSwitchCase
    {
        public static void Example1Inicio()
        {
            Console.WriteLine("\nMENU:");
            Console.WriteLine("1 - Ver produtos");
            Console.WriteLine("2 - Fazer pedido");
            Console.WriteLine("0 - Sair");
            Console.Write("Escolha uma opção: ");

            int opcao = int.Parse(Console.ReadLine());

            if (opcao == 1)
            {
                Console.WriteLine("Mostrando produtos…");
            }
            else if (opcao == 2)
            {
                Console.WriteLine("Pedido realizado!");
            }
            else if (opcao == 0)
            {
                Console.WriteLine("Saindo…");
            }
            else
            {
                Console.WriteLine("Opção inválida!");
            }
        }

        public static void Example1Fim()
        {
            Console.WriteLine("\nMENU:");
            Console.WriteLine("1 - Ver produtos");
            Console.WriteLine("2 - Fazer pedido");
            Console.WriteLine("0 - Sair");
            Console.Write("Escolha uma opção: ");

            int opcao = int.Parse(Console.ReadLine());

            switch (opcao)
            {
                case 1:
                    Console.WriteLine("Monstrando produtos…");
                    break;
                case 2:
                    Console.WriteLine("Pedido realizado!");
                    break;
                case 0:
                    Console.WriteLine("Saindo…");
                    break;
                default:
                    Console.WriteLine("Opção inválida!");
                    break;
            }
        }

        public static void Example2Inicio()
        {
            Console.WriteLine("Digite o tipo de cliente (Comum, VIP, Premium):");
            string tipoCliente = Console.ReadLine();

            decimal desconto;

            if (tipoCliente == "Comum")
            {
                desconto = 0.05m;
            }
            else if (tipoCliente == "VIP")
            {
                desconto = 0.10m;
            }
            else if (tipoCliente == "Premium")
            {
                desconto = 0.15m;
            }
            else
            {
                desconto = 0.00m;
            }

            Console.WriteLine(desconto);
        }

        public static void Example2Fim()
        {
            Console.WriteLine("Digite o tipo de cliente (Comum, VIP, Premium):");
            string tipoCliente = Console.ReadLine();

            decimal desconto;

            desconto = tipoCliente switch
            {
                "Comum" => 0.05m,
                "VIP" => 0.10m,
                "Premium" => 0.15m,
                _ => 0.00m
            };

            Console.WriteLine(desconto);
        }

        public static void Ex1() //Calculadora de operações básicas
        {
            Console.WriteLine("Digite o primeiro número:");
            double numero1 = double.Parse(Console.ReadLine());

            Console.WriteLine("Digite o segundo número:");
            double numero2 = double.Parse(Console.ReadLine());

            Console.WriteLine("Digite a operação (+, -, *, /):");
            string operacao = Console.ReadLine();

            string[] operacoesValidas = { "+", "-", "*", "/" };

            if (!operacoesValidas.Contains(operacao))
            {
                Console.WriteLine("Operação inválida");
                return;
            }

            if ((numero2 == 0) && (operacao == "/"))
            {
                Console.WriteLine("Divisão impossível");
                return;
            }

            double resultado = operacao switch
            {
                "+" => numero1 + numero2,
                "-" => numero1 - numero2,
                "/" => numero1 / numero2,
                "*" => numero1 * numero2,
            };

            Console.WriteLine($"Resultado: {resultado}");
        }

        public static void Ex2() //Saudação personalizada
        {
            Console.WriteLine("Que momento do dia é agora?");
            string momentoDoDia = Console.ReadLine();

            Console.WriteLine("Qual o seu nome?");
            string nome = Console.ReadLine();

            switch (momentoDoDia) {
                case "1":
                    Console.WriteLine($"Bom Dia, {nome}");
                    break;
                case "2":
                    Console.WriteLine($"Boa Tarde, {nome}");
                    break;
                case "3":
                    Console.WriteLine($"Boa Noite, {nome}");
                    break;
                default:
                    Console.WriteLine("Opção inválida");
                    break;
            }
        }

        public static void Ex3() //Sistema de recompensas
        {
            Console.WriteLine("Digite o código de recompensa (DOBRAR, CURAR, OURO, ESPECIAL):");
            string cupom = Console.ReadLine();

            string message = cupom switch
            {
                "DOBRAR" => "Ganhar 2x EXP por 1 hora.",
                "CURAR" => "Poção de cura.",
                "OURO" => "1000 moedas de ouro.",
                "ESPECIAL" => "Item lendário.",
                _ => "Recompensa indisponível"
            };

            Console.WriteLine(message);
        }

        public static void Ex4()  //Refatorando a organização de livros
        {
            Console.WriteLine("Digite o código do livro: ");
            string codigo = Console.ReadLine();

            if (!int.TryParse(codigo, out int _) || codigo.Length != 3)
            {
                Console.WriteLine("Código Inválido");
            }

            string categoria = codigo.Substring(0, 1);

            string nomecategoria = categoria switch
            {
                "1" => "Ficção Científica",
                "2" => "Literatura Clássica",
                "3" => "Fantasia",
                "4" => "Romance",
                "5" => "Suspense/Mistério",
                "6" => "Não Ficção",
                "7" => "Biografias/Memórias",
                "8" => "Distopia",
                "9" => "Infantojuvenil",
                _ => "Código inexistente"
            };

            Console.WriteLine(nomecategoria);
        }

        public static void Ex5() //Autenticação de usuário
        {
            Console.WriteLine("Sistema de Autenticação");
            Console.WriteLine("-----------------------");
            Console.Write("Digite seu nome de usuário: ");

            string nome = Console.ReadLine();

            if (ValidaUsuarioAdmin(nome))
            {
                Console.WriteLine($"Bem vindo, {nome}!");
            }
            else
            {
                Console.WriteLine("Usuário não cadastrado.");

                Console.WriteLine("Opções disponíveis:");
                Console.WriteLine("[1] Cadastrar novo usuário");
                Console.WriteLine("[2] Acessar como convidado");
                Console.WriteLine("[3] Sair");
            }
            string opcao = Console.ReadLine();

            switch (opcao)
            {
                case "1":
                    Console.WriteLine($"Novo usuário '{nome}' cadastrado com sucesso!");
                    break;
                case "2":
                    Console.WriteLine("Acesso concedido como convidado.");
                    break;
                case "3":
                    Console.WriteLine("Tchau");
                    break;
                default:
                    Console.WriteLine("Opção inválida. Encerrando sistema");
                    break;
            }
        }

        private static bool ValidaUsuarioAdmin(string nomeUsuario)
        {
            return nomeUsuario == "Admin";
        }
    }
}
