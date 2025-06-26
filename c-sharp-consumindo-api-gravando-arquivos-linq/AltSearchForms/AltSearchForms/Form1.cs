using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Net.Http;
using System.Security.Cryptography.X509Certificates;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace AltSearchForms
{
    public partial class Form1: Form
    {
        public Form1()
        {
            InitializeComponent();

        }



        private static async Task<Card> ReadCard(string pCard)
        {
            using (HttpClient client = new HttpClient())
            {
                string resposta = await client.GetStringAsync($"https://api.altered.gg/cards/{pCard}");
                return JsonConvert.DeserializeObject<Card>(resposta);
            }
        }

        private static async Task<CardSearchResult> ReadAllUniqueCardsByName(string name)
        {
            using (HttpClient client = new HttpClient())
            {
                string json = await client.GetStringAsync("https://api.altered.gg/cards?rarity[]=UNIQUE&translations.name=The%20Machine%20in%20the%20Ice&itemsPerPage=1&locale=en-us");
                var result = JsonConvert.DeserializeObject<CardSearchResult>(json);

                var card = result.Cards.FirstOrDefault();
                if (card != null)
                {
                    MessageBox.Show($"Card name: {card.Name}\nFaction: {card.MainFaction?.Name}");
                }

                return result;
            }

        }

        private async void button1_Click(object sender, EventArgs e)
        {
            try
            {
                var carta = await ReadAllUniqueCardsByName("");
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Erro: {ex.Message}");
            }
        }
    }
}
