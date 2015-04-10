using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GrepConsole
{
    public class Launcher
    {
        readonly string[] _args;
        ArgumentParser _parser;
        private ArgsList argsList;
         

        public Launcher(string[] args, ArgumentParser parser)
        {
            _args = args;
            _parser = new ArgumentParser(args);
            argsList = new ArgsList();
        }

        public void RunProgram() {
            if (_args.Length > 0)
            {
                argsList = _parser.Parse();
                var consoleProgram = new GrepConsoleProgram(argsList);
            }
            else
            {
                // TODO: Otworzyć graficzny interfejs
            }
        }
    }
}
