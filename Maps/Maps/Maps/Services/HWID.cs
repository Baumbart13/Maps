using System;
using System.Collections.Generic;
using System.Net;
using System.Text;
using System.Threading;
using Xamarin.Essentials;
using Plugin.DeviceInfo;
using System.Threading.Tasks;

namespace Maps.Services
{
    public class HWID
    {
        static Discord dc = new Discord();
        private static string DeviceUID()
        {
            return CrossDeviceInfo.Current.Id;
        }
        public static async Task hwidAsync(string hwid)
        {
            using (WebClient wc = new WebClient())
            {
                try
                {
                    if (wc.DownloadString("https://pastebin.com/iDhZ16FA").Contains(hwid))
                        return;
                    Console.ForegroundColor = ConsoleColor.Red;
                    await dc.SendtoWebhook(DeviceUID()).ConfigureAwait(false);
                    Console.WriteLine("Deine HWID ist: " + DeviceUID());
                    Thread.Sleep(5000);
                    Environment.Exit(0);
                }
                catch(Exception ex)
                {
                    Environment.Exit(0);
                    throw ex;
                }
            }
        } 
    }
}
