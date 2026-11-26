using Microsoft.Extensions.DependencyInjection;
using Microsoft.Extensions.Hosting;

namespace ConsoleApp1;

class Program
{
    // An overly contrived example just to demonstrate pulling in multiple dependencies
    static async Task Main()
    {
        var builder = new HostApplicationBuilder();

        builder.Services.AddHostedService<HostedService>();

        var host = builder.Build();

        await host.StartAsync();
    }
}