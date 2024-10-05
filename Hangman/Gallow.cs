namespace Hangman
{
    public class Gallow
    {
        //private List<>string[] wordsDictionary = { "apple", "house", "tiger", "beach", "cloud", "river", "plane", "snake", "chair", "grass" };

        List<(string Word, string Hint)> wordsList = new List<(string Word, string Hint)>
        {
            ( "apple",  "A round fruit often found in shades of red, green, or yellow." ),
            ( "house",  "A structure where people live, providing shelter." ),
            ( "tiger",  "A large wild cat known for its orange coat with black stripes." ),
            ( "beach",  "A sandy area along the shore, popular for relaxation." ),
            ( "cloud",  "A visible mass of condensed water vapor in the atmosphere." ),
            ( "river",  "A natural flowing watercourse that usually flows into an ocean." ),
            ( "plane",  "A vehicle designed for air travel, typically with wings." ),
            ( "snake",  "A legless reptile known for its ability to slither."),
            ( "chair",  "A piece of furniture designed for sitting." ),
            ( "grass",  "A common green plant that covers the ground." ),
            ( "grasshoper", "A leaping insect that is found all over the world." ),
        };

        public (string Word, string Hint) GetRandomWord()
        {
            Random random = new Random();
            int randomIndex = random.Next(0, wordsList.Count);
            return wordsList[randomIndex];
        }
    }  
}
