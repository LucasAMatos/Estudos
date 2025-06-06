using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ScreenSound
{
    class MenuSair : Menu
    {
        public override void Executar(Dictionary<string, List<int>> bandasRegistradas)
        {
            Console.WriteLine("Tchau tchau :)");
        }
    }
}
