using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Speech.Recognition;

namespace SpeechToText
{
    class GrammarType
    {
        static SpeechRecognitionEngine sengine;

        // Create custom Grammar
        public static void RecogniseGrammarSpeech()
        {
            sengine = new SpeechRecognitionEngine(new System.Globalization.CultureInfo("en-AU"));
            sengine.SetInputToDefaultAudioDevice();
            sengine.LoadGrammar(new Grammar(new GrammarBuilder( new Choices(new String[] { "Start", "Stop", "Text", "Speech"}))));
            sengine.RecognizeAsync(RecognizeMode.Multiple);
            sengine.SpeechRecognized += new EventHandler<SpeechRecognizedEventArgs>(sengine_speechRecognised);
        }

        public static void sengine_speechRecognised(object ob, SpeechRecognizedEventArgs e)
        {
            Console.WriteLine(e.Result.Text);
        }
    }
}

