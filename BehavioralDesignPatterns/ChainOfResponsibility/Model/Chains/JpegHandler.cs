using BehavioralDesignPatterns.ChainOfResponsibility.Interface;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BehavioralDesignPatterns.ChainOfResponsibility.Model.Chains
{
    class JpegHandler : IFileHandler
    {
        IFileHandler _nextChain;

        public const string EXTENTION_JPG = ".jpg";
        public const string EXTENTION_JPEG = ".jpeg";

        public void Handle(File file)
        {
            if(file.Extention.Equals(EXTENTION_JPG) || file.Extention.Equals(EXTENTION_JPEG))
            {
                Console.WriteLine("JPEG HANLDER - Reading the file");
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
