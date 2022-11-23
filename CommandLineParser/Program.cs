using CmdParser.Parser;
using Microsoft.Extensions.DependencyInjection;
using Microsoft.Extensions.Hosting;

namespace Console_DI_Template
{
    public class Program
    {
        static void Main(string[] args)
        {
            IHost host = CreateHostBuilder(args).Build();
            
            var barService = host.Services.GetService<IBarService>();

            barService.ParseAndDoWork(args);

        }

        private static IHostBuilder CreateHostBuilder(string[] args)
        {
            return Host.CreateDefaultBuilder(args)
                .ConfigureServices((_, services) =>
                    services
                    .AddTransient<IBarService, BarService>()
                    .AddTransient<IFooService, FooService>()
                    .AddScoped<Options>()
                    );
        }
    }
}