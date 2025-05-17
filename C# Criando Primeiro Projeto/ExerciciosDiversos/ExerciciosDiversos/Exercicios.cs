using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.InteropServices;
using System.Text;
using System.Threading.Tasks;

namespace ExerciciosDiversos
{
    public class Exercicios
    {
        void Nota()
        {
            // Criar uma variável chamada notaMedia e atribua um valor inteiro a ela.Caso seu valor seja maior ou igual a 5, escreva na tela "Nota suficiente para aprovação".
            int notaMedia = 0;
            Console.Write("Digite o valor da média do aluno:");
            notaMedia = int.Parse(Console.ReadLine());

            if (notaMedia >= 5)
            {
                Console.WriteLine("Nota suficiente para aprovação");
            }
        }

        void Lista()
        {
            //Criar uma lista de linguagens de programação, com as linguagens C#, Java e JavaScript.
            List<string> Linguagens = new List<string>(){
                "C#",
                "Java",
                "Javastript"
            };

            //Exibir o valor "C#" no console, utilizando a lista criada no exercício anterior.
            Console.WriteLine(Linguagens.First());

            //Criar um programa que, dado a entrada de dados de um número n inteiro, a partir do teclado, exibir a n-ésima posição de uma lista.
            Console.Write($"Digite uma posição na lista de 1 a {Linguagens.Count}");

            int opcao = int.Parse(Console.ReadLine());

            if (opcao < 1 || opcao > Linguagens.Count)
            {
                Console.WriteLine("Opção inválida");
                return;
            }

            Console.WriteLine(Linguagens[opcao - 1]);
        }

        void Adivinhacao()
        {
            int randomico = new Random().Next(1, 100);
            Console.WriteLine("Pensei em um número entre 1 e 100 você consegue acertar?");

            int numeroDigitado = int.Parse(Console.ReadLine());

            if (numeroDigitado < 1 || numeroDigitado > 100)
            {
                Console.WriteLine("Você não sabe brincar!");
                return;
            }

            if (numeroDigitado > randomico)
            {
                Console.WriteLine("Chutou Alto Demais! Deveria tentar ser astronauta!");
                return;
            }

            if (numeroDigitado < randomico)
            {
                Console.WriteLine("Nossa você me dá tão pouco assim??");
                return;
            }

            Console.WriteLine("Como você sabia?");
        }

        void Interpolacao()
        {
            Console.WriteLine("Digite 2 números e vamos trazer para você o resultado das 4 operações básicas destes números:");
            Console.WriteLine("Número 1:");
            float numero1 = float.Parse(Console.ReadLine());
            Console.WriteLine("Número 2:");
            float numero2 = float.Parse(Console.ReadLine());

            Console.WriteLine($"Soma: {numero1 + numero2}");
            Console.WriteLine($"Subtracao: {numero1 - numero2}");
            Console.WriteLine($"Multiplicação: {numero1 * numero2}");
            if (numero2 != 0)
            {
                Console.WriteLine($"Divisão: {numero1 / numero2}");
            }
        }

        void SomaLista()
        {
            int leituraConsole;
            List<int> numerosDigitados = new List<int>();

            Console.WriteLine("Digite números que deseja somar caso não queira mais somar digite 0");

            do
            {
                Console.Write("Proximo Número:");
                leituraConsole = int.Parse(Console.ReadLine());

                numerosDigitados.Add(leituraConsole);
            }
            while (leituraConsole != 0);

            Console.WriteLine($"A soma dos números digitados é {numerosDigitados.Sum()}");
        }

        void ListarBandas()
        {
            List<string> listaBandas = new List<string>();
            string leituraConsole = string.Empty;

            Console.WriteLine("Liste nome de bandas que você gosta e trarei na ordem alfabética!!");

            do
            {
                Console.Write("Banda:");
                leituraConsole = Console.ReadLine();

                if (!string.IsNullOrEmpty(leituraConsole))
                {
                    listaBandas.Add(leituraConsole);
                }
            }
            while (leituraConsole != string.Empty);
            listaBandas.Sort();

            Console.WriteLine($"Bandas Prediletas: {String.Join(", ", listaBandas)}");
        }

        void MostrarMedia()
        {
            var notasAlunos = new Dictionary<string, Dictionary<string, List<int>>> {
                { "Ana", new Dictionary<string, List<int>> {
                    { "C#", new List<int> { 8, 7, 6 } },
                    { "Java", new List<int> { 7, 6, 5 } },
                    { "Python", new List<int> { 9, 8, 8 } }
                }},
                { "Maria", new Dictionary<string, List<int>> {
                    { "C#", new List<int> { 6, 5, 4 } },
                    { "Java", new List<int> { 8, 7, 6 } },
                    { "Python", new List<int> { 6, 10, 5 } }
                }},
                { "Luiza", new Dictionary<string, List<int>> {
                    { "C#", new List<int> { 2, 3, 10 } },
                    { "Java", new List<int> { 8, 8, 8 } },
                    { "Python", new List<int> { 7, 7, 7 } }
                }}
            };

            Console.WriteLine($"Alunos da turma: {string.Join(", ", notasAlunos.Keys)}");
            Console.WriteLine("De qual aluno você quer ver a média?");
            var aluno = Console.ReadLine();

            if (notasAlunos.ContainsKey(aluno))
            {
                notasAlunos.TryGetValue(aluno, out Dictionary<string, List<int>> notasDoAluno);

                foreach (KeyValuePair<string, List<int>> notaDaMateria in notasDoAluno)
                {
                    Console.WriteLine($"A media do aluno {aluno} na matéria {notaDaMateria.Key} é {notaDaMateria.Value.Average()}.");
                }
            }
            else
            {
                Console.WriteLine($"Este aluno deve ser de outra classe");
            }

        }

        void EstoqueDaLoja()
        {
            var estoque = new Dictionary<string, int>()
            {
                { "Arroz", 50 },
                { "Feijão", 30 },
                { "Macarrão", 40 },
                { "Açúcar", 25 },
                { "Sal", 60 },
                { "Óleo", 20 },
                { "Farinha", 35 },
                { "Café", 15 },
                { "Leite", 45 },
                { "Biscoito", 10 }
            };

            Console.WriteLine($"Produtos com Estoque: {string.Join("|", estoque.Keys)}");
            Console.Write($"De qual  produto deseja saber quantidade?");
            var produto = Console.ReadLine();

            if (estoque.ContainsKey(produto))
                Console.WriteLine($"Produto {produto} com {estoque.GetValueOrDefault(produto)} itens");
            else
                Console.WriteLine($"Produto não encontrado");
        }

        void PerguntasRespostas()
        {
            var quiz = new Dictionary<string, string>();

            char continuar = 's';
            do
            {
                Console.Clear();
                Console.Write("Digite sua pergunta:");
                var pergunta = Console.ReadLine();
                Console.Write("Qual é a Resposta:");
                var resposta = Console.ReadLine();

                quiz.Add(pergunta, resposta);

                Console.Write("Deseja incluir mais perguntas?");

                continuar = Console.ReadKey().KeyChar;
            } while (continuar == 's' || continuar == 'S');

            Console.WriteLine("Perguntas digitadas:");
            foreach (KeyValuePair<string, string> charada in quiz)
            {
                Console.WriteLine($"Pergunta: {charada.Key}? Resposta: {charada.Value}");
            }
        }

    }
}
