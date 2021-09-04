using System;
using System.Collections.Generic;
using System.Text;
using System.Threading.Tasks;
namespace Maps.Services
{
    // this class is meant to scan the device for an available internet connection, because we need to check the unique device id
    class InternetService
    {
        public bool HasConnection()
        {
            return Plugin.Connectivity.CrossConnectivity.Current.IsConnected;
        }
    }
}
