using CommandLine;

namespace CmdParser.Parser
{
    public class Options
    {
        [Option('v', "verbose", Required = false, HelpText = "Set output to verbose messages.")]
        public bool Verbose { get; set; }

        [Option('p', "print", Required = false, HelpText = "Prints the welcome message.")]
        public bool PrintWelcome { get; set; }

        [Option('w', "work", Required = false, HelpText = "Do work.")]
        public bool Do { get; set; }
    }
}
