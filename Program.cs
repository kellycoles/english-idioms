﻿using System;
using System.Collections.Generic;

namespace englishIdioms {
    class Program {
        static void Main (string[] args) {
            Dictionary<string, List<string>> idioms = new Dictionary<string, List<string>> ();
            idioms.Add ("Penny", new List<string> { "A", "penny", "for", "your", "thoughts" });
            idioms.Add ("Injury", new List<string> { "Add", "insult", "to", "injury" });
            idioms.Add ("Moon", new List<string> { "Once", "in", "a", "blue", "moon" });
            idioms.Add ("Grape", new List<string> { "I", "heard", "it", "through", "the", "grapevine" });
            idioms.Add ("Murder", new List<string> { "Kill", "two", "birds", "with", "one", "stone" });
            idioms.Add ("Limbs", new List<string> { "It", "costs", "an", "arm", "and", "a", "leg" });
            idioms.Add ("Grain", new List<string> { "Take", "what", "someone", "says", "with", "a", "grain", "of", "salt" });
            idioms.Add ("Fences", new List<string> { "I'm", "on", "the", "fence", "about", "it" });
            idioms.Add ("Sheep", new List<string> { "Pulled", "the", "wool", "over", "his", "eyes" });
            idioms.Add ("Lucifer", new List<string> { "Speak", "of", "the", "devil" });

            //loop through Dictionary
            // Iterate the List of Dictionaries
            //   foreach (KeyValuePair<string,List<string>> kvp in idioms) {
            //         Console.WriteLine ($"{kvp.Key}: {kvp.Value}");
            //     }

              foreach (KeyValuePair <string, List<string>> kvp in idioms) {
                    Console.WriteLine ($"{kvp.Key}: {String.Join(" ", kvp.Value)}");
                }

        }
    }
}