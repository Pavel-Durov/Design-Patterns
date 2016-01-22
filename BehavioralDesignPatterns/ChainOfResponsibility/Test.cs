using BehavioralDesignPatterns.ChainOfResponsibility.Interface;
using BehavioralDesignPatterns.ChainOfResponsibility.Model;
using BehavioralDesignPatterns.ChainOfResponsibility.Model.Chains;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BehavioralDesignPatterns.ChainOfResponsibility
{
    class Test
    {
        public static void Run()
        {
            File file = new File("my-image", ".jpg");

            IFileHandler handler = new JpegHandler();
            IFileHandler pngHandler = new PngHandler();
            IFileHandler pdfHandler = new PdfHandler();

            handler.SetNext(pngHandler);
            pngHandler.SetNext(pdfHandler);

            handler.Handle(file);
        }
    }
}
