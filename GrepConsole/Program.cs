using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GrepConsole
{
    class Program
    {

        static void Main(string[] args)
        {
            ArgumentParser Parser = new ArgumentParser(args);
            Launcher Launcher = new Launcher(args, Parser);
            Launcher.RunProgram();
        }
    }
}
