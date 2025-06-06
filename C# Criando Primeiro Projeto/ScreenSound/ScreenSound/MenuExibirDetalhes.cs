using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ScreenSound.Menus
{
    class MenuExibirDetalhes : Menu
    {
        public override void Executar(Dictionary<string, List<int>> bandasRegistradas)
        {
            base.Executar(bandasRegistradas);
            ExibirTituloDaOpcao("Exibir detalhes da banda");
            Console.Write("Digite o nome da banda que deseja conhecer melhor: ");
            string nomeDaBanda = Console.ReadLine()!;
            if (bandasRegistradas.ContainsKey(nomeDaBanda))
            {
                List<int> notasDaBanda = bandasRegistradas[nomeDaBanda];
                Console.WriteLine($"\nA média da banda {nomeDaBanda} é {notasDaBanda.Average()}.");
                /**
                * ESPAÇO RESERVADO PARA COMPLETAR A FUNÇÃO
                */
                Console.WriteLine("Digite uma tecla para votar ao menu principal");
                Console.ReadKey();
                Console.Clear();

            }
            else
            {
                Console.WriteLine($"\nA banda {nomeDaBanda} não foi encontrada!");
                Console.WriteLine("Digite uma tecla para voltar ao menu principal");
                Console.ReadKey();
                Console.Clear();
            }
        }
    }
}
