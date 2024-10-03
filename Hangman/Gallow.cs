using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Hangman
{
    public class Gallow
    {
        private string[] wordsDictionary = { "apple", "house", "tiger", "beach", "cloud", "river", "plane", "snake", "chair", "grass" };

        public string GetRandomWord()
        {
            Random random = new Random();
            int randomIndex = random.Next(0, wordsDictionary.Length);
            return wordsDictionary[randomIndex];
        }
    }
}
