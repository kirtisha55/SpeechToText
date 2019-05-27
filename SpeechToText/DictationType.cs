using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Speech;
using System.Speech.Recognition;

namespace SpeechToText
{
    class DictationType
    {
        static SpeechRecognitionEngine sengine;

        // Dictation method
        public static void RecogniseSpeech()
        {
            sengine = new SpeechRecognitionEngine(new System.Globalization.CultureInfo("en-US"));
            sengine.SetInputToDefaultAudioDevice();
            DictationGrammar dictationGrammar = new DictationGrammar();
            sengine.LoadGrammar(dictationGrammar);
            sengine.RecognizeAsync(RecognizeMode.Multiple);
            sengine.SpeechRecognized += new EventHandler<SpeechRecognizedEventArgs>(sengine_speechRecognised);
        }

        public static void sengine_speechRecognised(object ob, SpeechRecognizedEventArgs e)
        {
            Console.WriteLine(e.Result.Text);
        }
    }
}
