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
        int foundArgsCount;

        public ArgumentParser(string[] args)
        {
            _args = args;
            _argsList = new ArgsList();
            foundArgsCount = 1;
        }

        public ArgsList Parse()
        {
            ReadUrlFromArgs();
            FindCountWordsArgAndEditList();
            FindSerchWordParameterAndEditList();

            if (foundArgsCount != _args.Length)
                throw new InvalidArgumentsException();

            return _argsList;
        }

        private void ReadUrlFromArgs()
        {
            _argsList.URL = _args[0];
        }

        private void FindSerchWordParameterAndEditList()
        {
            for (int i = 1; i < _args.Length; ++i)
            {
                if (_args[i] == "-s")
                {
                    if (i + 1 >= _args.Length - 1)
                    {
                        throw new InvalidArgumentsException();
                    }
                    else
                    {
                        _argsList.Word = _args[i + 1];
                        _argsList.SearchWord = true;
                        foundArgsCount += 2;
                        break;
                    }
                }
            }
        }

        private void FindCountWordsArgAndEditList()
        {
            if (_args.Contains("-c"))
            {
                _argsList.CountWords = true;
                foundArgsCount++;
            }
            else
            {
                _argsList.CountWords = false;
            }
        }
    }
}
