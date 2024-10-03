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

        // Event handlers for letter buttons A-Z
        private void btn_A_Click(object sender, EventArgs e)
        {
            ProcessLetter('A');
        }

        private void btn_B_Click(object sender, EventArgs e)
        {
            ProcessLetter('B');
        }

        private void btn_C_Click(object sender, EventArgs e)
        {
            ProcessLetter('C');
        }

        private void btn_D_Click(object sender, EventArgs e)
        {
            ProcessLetter('D');
        }

        private void btn_E_Click(object sender, EventArgs e)
        {
            ProcessLetter('E');
        }

        private void btn_F_Click(object sender, EventArgs e)
        {
            ProcessLetter('F');
        }

        private void btn_G_Click(object sender, EventArgs e)
        {
            ProcessLetter('G');
        }

        private void btn_H_Click(object sender, EventArgs e)
        {
            ProcessLetter('H');
        }

        private void btn_I_Click(object sender, EventArgs e)
        {
            ProcessLetter('I');
        }

        private void btn_J_Click(object sender, EventArgs e)
        {
            ProcessLetter('J');
        }

        private void btn_K_Click(object sender, EventArgs e)
        {
            ProcessLetter('K');
        }

        private void btn_L_Click(object sender, EventArgs e)
        {
            ProcessLetter('L');
        }

        private void btn_M_Click(object sender, EventArgs e)
        {
            ProcessLetter('M');
        }

        private void btn_N_Click(object sender, EventArgs e)
        {
            ProcessLetter('N');
        }

        private void btn_O_Click(object sender, EventArgs e)
        {
            ProcessLetter('O');
        }

        private void btn_P_Click(object sender, EventArgs e)
        {
            ProcessLetter('P');
        }

        private void btn_Q_Click(object sender, EventArgs e)
        {
            ProcessLetter('Q');
        }

        private void btn_R_Click(object sender, EventArgs e)
        {
            ProcessLetter('R');
        }

        private void btn_S_Click(object sender, EventArgs e)
        {
            ProcessLetter('S');
        }

        private void btn_T_Click(object sender, EventArgs e)
        {
            ProcessLetter('T');
        }

        private void btn_U_Click(object sender, EventArgs e)
        {
            ProcessLetter('U');
        }

        private void btn_V_Click(object sender, EventArgs e)
        {
            ProcessLetter('V');
        }

        private void btn_W_Click(object sender, EventArgs e)
        {
            ProcessLetter('W');
        }

        private void btn_X_Click(object sender, EventArgs e)
        {
            ProcessLetter('X');
        }

        private void btn_Y_Click(object sender, EventArgs e)
        {
            ProcessLetter('Y');
        }

        private void btn_Z_Click(object sender, EventArgs e)
        {
            ProcessLetter('Z');
        }

        // Event handlers to choose a new word
        private void btn_newWord_Click(object sender, EventArgs e)
        {
            StartNewGame();
        }

        // Event handler to reset the game
        // TODO - Implement the event
        private void btn_reset_Click(object sender, EventArgs e)
        {
            StartNewGame();
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

       
    }
}