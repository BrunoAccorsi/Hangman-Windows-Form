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
            ( "mountain", "A large natural elevation of the earth's surface rising abruptly from the surrounding level." ),
            ( "computer", "An electronic device for storing and processing data." ),
            ( "book", "A written or printed work consisting of pages bound together." ),
            ( "car", "A road vehicle, typically with four wheels, powered by an internal combustion engine." ),
            ( "ocean", "A vast body of salt water that covers much of the Earth's surface." ),
            ( "sunflower", "A tall plant with a large yellow flower head, known for turning to face the sun." ),
            ( "piano", "A large keyboard musical instrument with strings that are struck by hammers." ),
            ( "guitar", "A stringed musical instrument played with the fingers or a pick." ),
            ( "penguin", "A flightless seabird with black and white plumage and flipper-like wings." ),
            ( "volcano", "A mountain or hill with a crater or vent through which lava, rock fragments, hot vapor, and gas are being or have been erupted from the Earth's crust." )
        };

        public (string Word, string Hint) GetRandomWord()
        {
            Random random = new Random();
            int randomIndex = random.Next(0, wordsList.Count);
            return wordsList[randomIndex];
        }
    }  
}
