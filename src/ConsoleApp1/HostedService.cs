using ClassLibrary1;
using Microsoft.Extensions.Hosting;

namespace ConsoleApp1;

internal class HostedService : IHostedService
{
    public Task StartAsync(CancellationToken cancellationToken)
    {
        ConsolePrinter.Print(new PrintParameters("Starting"));
        return Task.CompletedTask;
    }
        
    public Task StopAsync(CancellationToken cancellationToken)
    {
        ConsolePrinter.Print(new PrintParameters("Stopping"));
        return Task.CompletedTask;
    }
}
