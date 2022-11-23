using CmdParser.Parser;
using CommandLine;
using Microsoft.Extensions.Configuration;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Console_DI_Template
{
    public class BarService : IBarService
    {
        public IFooService FooService { get; }
        public Options Opt { get; }
        public IConfiguration Configuration { get; }

        private string? key;

        public BarService(IFooService fooService, Options opt, IConfiguration configuration)
        {
            FooService = fooService;
            Opt = opt;
            Configuration = configuration;
            key = Configuration.GetValue<string>("Key");
        }

        public void ParseAndDoWork(string[] args)
        {
            
            Parser.Default.ParseArguments<Options>(args)
                   .WithParsed<Options>(o => {

                       if (o.Verbose)
                       {
                           DoSomeRealWork();
                       }
                       else if (o.PrintWelcome)
                       {
                           PrintWelcome();
                       }
                       else
                       {
                           Console.WriteLine("Invalid Choice");
                       }
                   
                   });
        }

        public void DoSomeRealWork()
        {
           FooService.DoSomeWork();

            Console.WriteLine(key);
        }

        public void PrintWelcome()
        {
            Console.WriteLine("Hello World from BarService!");
        }

    }
}
