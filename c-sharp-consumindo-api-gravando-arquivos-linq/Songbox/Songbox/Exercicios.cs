using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Songbox
{
    class ExerciciosAula1
    {
        public async void Exercicio1()
        {
            using HttpClient client = new();
            try
            {
                string response = await client.GetStringAsync("");

                Console.WriteLine(response);
            }
            catch (Exception ex)
            {
                Console.WriteLine($"Erro na requisição: {ex.Message}");
            }
        }

        public void Exercicio2()
        {
            int a = 0;
            int b = 0;
            try
            {
                Console.Write("Lendo parâmetro A:");
                a = int.Parse(Console.ReadLine());
                Console.Write("Lendo parâmetro B:");
                b = int.Parse(Console.ReadLine());

                var result = a / b;

                Console.WriteLine($"a divisão de {a} por {b} dá {result}");
            }
            catch (Exception ex)
            {
                Console.WriteLine($"Erro na divisão de {a} por {b}: {ex.Message}");
            }
        }

        public void Exercicio3()
        {
            int[] listaInteiros = { 1, 3 };

            try
            {
                var inteiro = listaInteiros[14];
            }
            catch (Exception ex)
            {
                Console.WriteLine($"Erro na aplicação: {ex.Message}");
            }
        }
    }
}
