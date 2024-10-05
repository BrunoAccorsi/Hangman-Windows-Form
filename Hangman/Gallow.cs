namespace Hangman
{
    public class Gallow
    {
        //private List<>string[] wordsDictionary = { "apple", "house", "tiger", "beach", "cloud", "river", "plane", "snake", "chair", "grass" };

        List<(string Word, string Hint)> wordsList = new List<(string Word, string Hint)>
        {
            ( "apple","A round fruit often found in shades of red, green, or yellow." ),
            ( "house","A structure where people live, providing shelter." ),
            ( "tiger","A large wild cat known for its orange coat with black stripes." ),
            ( "beach","A sandy area along the shore, popular for relaxation." ),
            ( "cloud","A visible mass of condensed water vapor in the atmosphere." ),
            ( "river","A natural flowing watercourse that usually flows into an ocean." ),
            ( "plane","A vehicle designed for air travel, typically with wings." ),
            ( "snake","A legless reptile known for its ability to slither." ),
            ( "chair","A piece of furniture designed for sitting." ),
            ( "grass","A common green plant that covers the ground." ),
            ( "grasshopper","A leaping insect that is found all over the world." ),
            ( "mountain","A large natural elevation of the earth's surface." ),
            ( "computer","An electronic device for processing data." ),
            ( "castle","A large fortified building or group of buildings." ),
            ( "garden","A plot of ground where plants are cultivated." ),
            ( "ocean","A vast body of salt water covering much of Earth." ),
            ( "sunflower","A tall plant with a large yellow flower head." ),
            ( "piano","A keyboard musical instrument with strings." ),
            ( "guitar","A stringed instrument played by strumming or plucking." ),
            ( "penguin","A flightless bird with black and white feathers." ),
            ( "volcano","A mountain with a vent through which lava erupts." ),
            ( "island","Land completely surrounded by water." ),
            ( "forest","A large area dominated by trees." ),
            ( "butterfly","An insect with large, colorful wings." ),
            ( "bicycle","A vehicle with two wheels powered by pedals." ),
            ( "clock","A device for measuring and showing time." ),
            ( "camera","A device for capturing images or videos." ),
            ( "bridge","A structure built to span physical obstacles." ),
            ( "elephant","A large mammal known for its trunk and tusks." ),
            ( "rainbow","An arc of colors visible in the sky after rain." ),
            ( "planet","A celestial body orbiting a star." )
        };

        public (string Word, string Hint) GetRandomWord()
        {
            Random random = new Random();
            int randomIndex = random.Next(0, wordsList.Count);
            return wordsList[randomIndex];
        }
    }  
}
