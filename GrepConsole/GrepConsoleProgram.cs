using System;
using System.Collections.Generic;
using System.Diagnostics.Eventing.Reader;
using System.Linq;
using System.Security.Cryptography.X509Certificates;
using System.Text;
using System.Threading.Tasks;
using GrepEngine;
using DataProvider;
namespace GrepConsole
{
    public class GrepConsoleProgram
    {
        private ArgsList argsList;

        public GrepConsoleProgram(ArgsList argsList)
        {
            this.argsList = argsList;
        }

        private Grep grep;

        public void Run()
        {
            grep = new Grep(new Downloader().DownloadWebpageAsText(argsList.URL));
            if (argsList.CountWords)
            {
                Console.WriteLine("Occurances of a given word in all lines:");
                Console.WriteLine(grep.CountTokenOccurancesInAllLines(argsList.Word));
            }
            if (argsList.SearchWord)
            {
                Console.WriteLine("Lines where the given word occure:");
                Console.WriteLine(grep.GetLinesContainingSpecifiedToken(argsList.Word));
            }


        }
    }
}
