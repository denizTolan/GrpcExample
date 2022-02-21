using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Net;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Hosting;
using Microsoft.AspNetCore.Server.Kestrel.Core;
using Microsoft.Extensions.Hosting;

namespace GrpcExample.Server
{
    public class Program
    {
        const int PORT = 19020;

        public static void Main(string[] args)
        {
            CreateHostBuilder(args).Build().Run();


        }

        // Additional configuration is required to successfully run gRPC on macOS.
        // For instructions on how to configure Kestrel and gRPC clients on macOS, visit https://go.microsoft.com/fwlink/?linkid=2099682
        public static IHostBuilder CreateHostBuilder(string[] args) =>
            Host.CreateDefaultBuilder(args)
                .ConfigureWebHostDefaults(webBuilder =>
                {
                    webBuilder.UseStartup<Startup>()
                        .ConfigureKestrel(options =>
                        {
                            options.Limits.MinRequestBodyDataRate = null;
                            options.Listen(IPAddress.Any, PORT,
                                listenOptions =>
                                {
                                    listenOptions.UseHttps("grpcServer.pfx", "1511");
                                    listenOptions.Protocols = HttpProtocols.Http1AndHttp2;
                                });
                        });
                });
    }
}