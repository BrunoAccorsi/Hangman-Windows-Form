using System.Data;

namespace Hangman
{

    class Gallow
    {
        private string[] wordsDictionary = { "apple", "house", "tiger", "beach", "cloud", "river", "plane", "snake", "chair", "grass" };
        public int wrongGuesses = 0;
        public List<char> correctGuesses = [];

        public void DrawGallow()
        {
            switch (wrongGuesses)
            {
                case 0:
                    Console.WriteLine("  +---+");
                    Console.WriteLine("  |   |");
                    Console.WriteLine("      |");
                    Console.WriteLine("      |");
                    Console.WriteLine("      |");
                    Console.WriteLine("      |");
                    Console.WriteLine("=========");
                    break;
                case 1:
                    Console.WriteLine("  +---+");
                    Console.WriteLine("  |   |");
                    Console.WriteLine("  O   |");
                    Console.WriteLine("      |");
                    Console.WriteLine("      |");
                    Console.WriteLine("      |");
                    Console.WriteLine("=========");
                    break;
                case 2:
                    Console.WriteLine("  +---+");
                    Console.WriteLine("  |   |");
                    Console.WriteLine("  O   |");
                    Console.WriteLine("  |   |");
                    Console.WriteLine("      |");
                    Console.WriteLine("      |");
                    Console.WriteLine("=========");
                    break;
                case 3:
                    Console.WriteLine("  +---+");
                    Console.WriteLine("  |   |");
                    Console.WriteLine("  O   |");
                    Console.WriteLine(" /|   |");
                    Console.WriteLine("      |");
                    Console.WriteLine("      |");
                    Console.WriteLine("=========");
                    break;
                case 4:
                    Console.WriteLine("  +---+");
                    Console.WriteLine("  |   |");
                    Console.WriteLine("  O   |");
                    Console.WriteLine(" /|\\  |");
                    Console.WriteLine("      |");
                    Console.WriteLine("      |");
                    Console.WriteLine("=========");
                    break;
                case 5:
                    Console.WriteLine("  +---+");
                    Console.WriteLine("  |   |");
                    Console.WriteLine("  O   |");
                    Console.WriteLine(" /|\\  |");
                    Console.WriteLine(" /    |");
                    Console.WriteLine("      |");
                    Console.WriteLine("=========");
                    break;
                case 6:
                    Console.WriteLine("  +---+");
                    Console.WriteLine("  |   |");
                    Console.WriteLine("  O   |");
                    Console.WriteLine(" /|\\  |");
                    Console.WriteLine(" / \\  |");
                    Console.WriteLine("      |");
                    Console.WriteLine("=========");
                    break;
                default:
                    throw new Exception("the game has ended");
            }
        }

        public void DrawWord(string word, List<char> correctGuesses)
        {
            Console.Write("Word: ");
            foreach (char letter in word)
            {
                if (correctGuesses.Contains(letter))
                {
                    Console.Write(letter + " ");
                }
                else
                {
                    Console.Write("_ ");
                }
            }
            Console.WriteLine();
        }

        public string GetRandomWord()
        {
            Random random = new Random();
            int randomIndex = random.Next(0, wordsDictionary.Length);
            return wordsDictionary[randomIndex];
        }

        public bool IsGameOver()
        {
            if (wrongGuesses >= 6)
            {
                return true;
            }
            return false;
        }

        public bool IsWordGuessed(string word, List<char> correctGuesses)
        {
            foreach (char letter in word)
            {
                if (!correctGuesses.Contains(letter))
                {
                    return false;
                }
            }
            return true;
        }

        public void PlayGame()
        {
            string word = GetRandomWord();
            while (!IsGameOver() && !IsWordGuessed(word, correctGuesses))
            {
                DrawGallow();
                DrawWord(word, correctGuesses);
                Console.Write("Enter a letter: ");
                char letter = Console.ReadLine()[0];
                if (word.Contains(letter))
                {
                    correctGuesses.Add(letter);
                }
                else
                {
                    wrongGuesses++;
                }
            }
            DrawGallow();
            DrawWord(word, correctGuesses);
            if (IsWordGuessed(word, correctGuesses))
            {
                Console.WriteLine("Congratulations! You won!");
            }
            else
            {
                Console.WriteLine("Sorry, you lost. The word was: " + word);
            }
        }
    }
    internal static class Program
    {
        [STAThread]
        static void Main()
        {
            //Application.EnableVisualStyles();
            //Application.SetCompatibleTextRenderingDefault(false);
            //Application.Run(new Form1());
            Gallow gallow = new Gallow();

            gallow.PlayGame();
        }
    }
}