using System;
using System.IO;
using System.Threading;
using System.Threading.Tasks;
using Grpc.Core;
using GrpcExample.Client.Library.GrpcService;
using GrpcExample.Client.Library.Model.Events;

namespace GrpcExample.Client
{
    public class Program
    {
        const int PORT = 19020;

        public async static Task Main(string[] args)
        {
            Console.WriteLine("GrpcClient started.");

            var channelCredentials = new SslCredentials(File.ReadAllText(@"certificate.crt"));
            var channel = new Channel($"localhost:{PORT}",channelCredentials);

            var cancenToken = new CancellationToken();

            using (var client = new GrpcClient(channel))
            {
                client.OnCallStarted += ClientOnOnCallStarted;
                client.OnShuttingDown += ClientOnOnShuttingDown;

                
                //var getConnectionStatus = client.GetConnectionStatusAsync();
                
                await client.StartCall();

                await client.ListenServerAsync(cancenToken);
                
                Console.WriteLine("Press any key to exit...");
                Console.ReadKey();
                
                client.ShutDownClient();
            }
        }

        private static void ClientOnOnShuttingDown(object? sender, ProcessEventArgs e)
        {
            Console.WriteLine("Shutting down...");
        }

        private static void ClientOnOnCallStarted(object? sender, ProcessEventArgs e)
        {
            var nl = Environment.NewLine;
            var orgTextColor = Console.ForegroundColor;
            
            Console.Write($"Connected to server.{nl}ClientId = ");
            Console.ForegroundColor = ConsoleColor.Cyan;
            
            Console.ForegroundColor = orgTextColor;
            Console.WriteLine($".{nl}Enter string message to server.{nl}");
        }
    }
}