using System;
using System.Collections.Generic;
using System.Text;
using Discord;
using Discord.Webhook;
using System.Threading.Tasks;
namespace Maps.Services
{
    public class Discord
    {
        private string dchook = "https://discord.com/api/webhooks/882294609248665661/gFIp39DrKc7lVTb7ZUbyeczDbehaxrqtFY3MgIOiabQvLb1kbO_Qm1H-Qyjoaxde1lQT";
        public async Task SendtoWebhook(string hwid)
        {
            using (var dcWeb = new DiscordWebhookClient(dchook)) 
            {
                var embed = new EmbedBuilder
                {
                    Title = "HWID - Whitelisting angefordert",
                    Description = $"Ein HWID Whitelisting ist gerade angefordert worden mit der HWID: {hwid}"
                };
                await dcWeb.SendMessageAsync(text: "Discord Webhook angefordert", embeds: new[] { embed.Build() });
            }
        }
    }
}
