namespace Hangman
{
    public partial class Form1 : Form
    {
        private Gallow gallow;
        private string currentWord;
        private List<char> correctGuesses;
        private int wrongGuesses;

        public Form1()
        {
            InitializeComponent();
            StartNewGame();
        }

        // Initialize a new game
        private void StartNewGame()
        {
            gallow = new Gallow();
            currentWord = gallow.GetRandomWord();
            correctGuesses = new List<char>();
            wrongGuesses = 0;
            lbl_used.Text = "Used: ";
            UpdateWordDisplay();
            UpdateGallowDisplay();
        }

        // Update the word display on the form
        private void UpdateWordDisplay()
        {
            lbl_used.Text = "Used: " + string.Join(", ", correctGuesses);
            string displayWord = "";
            foreach (char letter in currentWord)
            {
                displayWord += correctGuesses.Contains(letter) ? letter + " " : "_ ";
            }
            lbl_used.Text += "\nWord: " + displayWord;
        }

        // Update the gallows display (Needs images added)
        private void UpdateGallowDisplay()
        {
            switch (wrongGuesses)
            {
                case 0:
                    // To be completed: Add an image for gallow_0 to Resources
                    pictureBox1.Image = Properties.Resources.gallow_0;
                    break;
                case 1:
                    // To be completed: Add an image for gallow_1 to Resources
                    pictureBox1.Image = Properties.Resources.gallow_1;
                    break;
                case 2:
                    // To be completed: Add an image for gallow_2 to Resources
                    pictureBox1.Image = Properties.Resources.gallow_2;
                    break;
                case 3:
                    // To be completed: Add an image for gallow_3 to Resources
                    pictureBox1.Image = Properties.Resources.gallow_3;
                    break;
                case 4:
                    // To be completed: Add an image for gallow_4 to Resources
                    pictureBox1.Image = Properties.Resources.gallow_4;
                    break;
                case 5:
                    // To be completed: Add an image for gallow_5 to Resources
                    pictureBox1.Image = Properties.Resources.gallow_5;
                    break;
                case 6:
                    // To be completed: Add an image for gallow_6 to Resources
                    pictureBox1.Image = Properties.Resources.gallow_6;
                    break;
            }
        }

        // Process the guessed letter
        private void ProcessLetter(char letter)
        {
            if (!correctGuesses.Contains(letter))
            {
                correctGuesses.Add(letter);

                if (!currentWord.Contains(letter))
                {
                    wrongGuesses++;
                }

                UpdateWordDisplay();
                UpdateGallowDisplay();

                if (wrongGuesses >= 6)
                {
                    MessageBox.Show($"You lost! The word was: {currentWord}");
                    StartNewGame();
                }
                else if (IsWordGuessed())
                {
                    MessageBox.Show("Congratulations! You won!");
                    StartNewGame();
                }
            }
        }

        // Check if the word is fully guessed
        private bool IsWordGuessed()
        {
            foreach (char letter in currentWord)
            {
                if (!correctGuesses.Contains(letter))
                {
                    return false;
                }
            }
            return true;
        }

        // Event handlers for letter buttons (other buttons need to be connected)
        private void btn_A_Click(object sender, EventArgs e)
        {
            ProcessLetter('A');
        }

        private void btn_B_Click(object sender, EventArgs e)
        {
            ProcessLetter('B');
        }

        // More letter buttons need to be connected here (C-Z)
        // To be completed: Implement event handlers for all letter buttons (C-Z)

        private void btn_newWord_Click(object sender, EventArgs e)
        {
            StartNewGame();
        }
    }
}