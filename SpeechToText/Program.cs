using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SpeechToText
{
    class Program
    {
        public static void Main(string[] args)
        {
            //DictationType.RecogniseSpeech();
            GrammarType.RecogniseGrammarSpeech();
            Console.ReadLine();
        }
       
    }
}
