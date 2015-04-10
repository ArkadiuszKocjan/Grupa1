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
        ArgsList _argsList;
        int count;

        public ArgumentParser(string[] args)
        {
            _args = args;
            _argsList = new ArgsList();
            count = 1;
        }

        public ArgsList Parse()
        {
            _argsList.URL = _args[0];

            if (_args.Contains("-c"))
            {
                _argsList.CountWords = true;
                count++;
            }
            else
            {
                _argsList.CountWords = false;
            }

            for(int i=1; i<_args.Length; ++i)
            {
                if (_args[i] == "-s")
                {
                    if(i+1 >= _args.Length-1)
                    {
                        throw new InvalidArgumentsException();
                    }
                    else
                    {
                        _argsList.Word = _args[i + 1];
                        _argsList.SearchWord = true;
                        count += 2;
                        break;
                    }
                }
            }

            if (count != _args.Length)
                throw new InvalidArgumentsException();

            return _argsList;
        }
    }
}
