using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GrepConsole
{
    public class Launcher
    {
        string[] _args;
        ArgumentParser _parser;

        public Launcher(string[] args, ArgumentParser parser)
        {
            _args = args;
            _parser = parser;
        }

        public void RunProgram() {
            if (_args.Length > 0)
            {

            }
            else
            {
                // TODO: Otworzyć graficzny interfejs
            }
        }
    }
}
