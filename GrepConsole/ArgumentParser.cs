using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GrepConsole
{
    public class ArgumentParser
    {
        string[] _args;

        public ArgumentParser(string[] args)
        {
            _args = args;
        }

        public ArgsList Parse()
        {
            ArgsList ArgsList = new ArgsList();

            if (_args.Contains("-c"))
            {
                ArgsList.CountWords = true;
            }
            else
            {
                ArgsList.CountWords = false;
            }

                for(int i=0; i<_args.Length; ++i)
                {
                    if (_args[i] == "-s")
                    {

                    }
                }

            return ArgsList;
        }
    }
}
