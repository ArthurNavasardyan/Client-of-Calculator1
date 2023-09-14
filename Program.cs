using Microsoft.AspNetCore.SignalR.Client;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ClientSignalR
{
    internal class Program
    {
        static HubConnection hubConnection;

        static async Task Main(string[] args)
        {
            hubConnection = new HubConnectionBuilder()
                 .WithUrl("https://localhost:7087/hub")
                 .Build();

            hubConnection.On<double>("Send", result => Console.WriteLine($"message from server:{result}"));

            await hubConnection.StartAsync();

            bool isExit = false;

            while (!isExit)
            {
                var massage = Console.ReadLine();

                if (massage == "exit")
                {
                    isExit = true;
                }
                
            }
            Console.ReadLine();

        }



    }
}
