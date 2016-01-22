using BehavioralDesignPatterns.ChainOfResponsibility.Interface;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BehavioralDesignPatterns.ChainOfResponsibility.Model.Chains
{
    class PngHandler : IFileHandler
    {
        IFileHandler _nextChain;

        public const string EXTENTION_PNG = ".png";

        public void Handle(File file)
        {
            if(file.Extention.Equals(EXTENTION_PNG))
            {
                Console.WriteLine("PNG HANLDER - Reading the file");

            }
            else
            {
                if(_nextChain == null)
                {
                    Console.WriteLine("Do not support this kind of files...");
                }
                else
                {
                    _nextChain.Handle(file);
                }
            }
        }

        public void SetNext(IFileHandler chain)
        {
            _nextChain = chain;
        }
    }
}
