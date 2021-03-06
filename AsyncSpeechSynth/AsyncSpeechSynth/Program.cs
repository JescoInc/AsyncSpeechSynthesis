﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Speech.Synthesis;
using System.Text;
using System.Threading;
using System.Threading.Tasks;

namespace AsyncSpeechSynth
{
    class Program
    {
        static void Main()
        {
            Example();
            Console.ReadLine();
        }

        static async void Example()
        {
            
            string t = await Task.Run(() => runThis());
        }

        static string runThis()
        {
            string result = Console.ReadLine();

            Thread.Sleep(1000);
            using (SpeechSynthesizer speech = new SpeechSynthesizer())
            {
                speech.SelectVoice("Microsoft Zira Desktop");
                speech.Speak(result);
            }
            return "0";
        }
    }
}
