using System;
using System.Collections.Generic;
using System.Linq;
using System.Reflection;
using ExerciciosDiversos;

class Program
{
    static void Main(string[] args)
    {
        var exercicios = new Exercicios();
        bool continuar = true;

        while (continuar)
        {
            Thread.Sleep(2000);
            Console.Clear();
            Console.WriteLine("Qual exercício você quer testar?\n");

            var metodos = typeof(Exercicios)
                .GetMethods(BindingFlags.NonPublic | BindingFlags.Instance | BindingFlags.DeclaredOnly)
                .Where(m => m.ReturnType == typeof(void)
                            && m.GetParameters().Length == 0
                            && !m.Name.StartsWith("<")
                            && m.Name != "RetorneAoMenuAnterior")
                .ToList();

            var opcoes = new Dictionary<int, MethodInfo>();

            for (int i = 0; i < metodos.Count; i++)
            {
                Console.WriteLine($"{i + 1} - {FormatarNomeMetodo(metodos[i].Name)}");
                opcoes[i + 1] = metodos[i];
            }

            Console.WriteLine("\n-1 - Sair");
            Console.Write("\nEscolha uma opção: ");
            var entrada = Console.ReadLine();

            if (entrada == "-1")
            {
                continuar = false;
                break;
            }

            if (int.TryParse(entrada, out int escolha) && opcoes.ContainsKey(escolha))
            {
                Console.Clear();
                opcoes[escolha].Invoke(exercicios, null);
            }
            else
            {
                Console.WriteLine("Opção inválida. Pressione qualquer tecla para tentar novamente...");
                Console.ReadKey();
            }
        }

        Console.WriteLine("Até a próxima!");
    }

    static string FormatarNomeMetodo(string nome)
    {
        // Converte o nome do método para algo mais legível
        return System.Text.RegularExpressions.Regex
            .Replace(nome, "([a-z])([A-Z])", "$1 $2");
    }
}
