using System.Net.Mail;

namespace Hangman
{
    public partial class Form1 : Form
    {
        private Gallow gallow;
        private (string Word, string Hint) currentWord;
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
            lbl_used.Text = "Used: " + string.Join(", ", correctGuesses).ToUpper();
            string displayWord = "";
            foreach (char letter in currentWord.Word)
            {
                displayWord += correctGuesses.Contains(letter) ? char.ToUpper(letter) + " " : "_ ";
            }
            lbl_used.Text += "\nWord: " + displayWord;
            lbl_hint.Text = currentWord.Hint;
        }

        // Update the gallows display (Needs images added)

        private void UpdateGallowDisplay()
        {
            byte[]? imageData = null;
            //Properties.Resources.Gallow0;
            switch (wrongGuesses)
            {
                case 0:
                    imageData = Properties.Resources.Gallow0;
                    break;
                case 1:
                    imageData = Properties.Resources.Gallow1;
                    break;
                case 2:
                    imageData = Properties.Resources.Gallow2;
                    break;
                case 3:
                    imageData = Properties.Resources.Gallow3;
                    break;
                case 4:
                    imageData = Properties.Resources.Gallow4;
                    break;
                case 5:
                    imageData = Properties.Resources.Gallow5;
                    break;
                case 6:
                    imageData = Properties.Resources.Gallow6;
                    break;
                case 7:
                    imageData = Properties.Resources.Gallow7;
                    break;

                default:
                    break;
            }

            if (imageData != null && imageData.Length > 0)
            {
                using (MemoryStream ms = new MemoryStream(imageData))
                {
                    pictureBox2.Image = Image.FromStream(ms);
                }
            }
        }


        // Process the guessed letter
        private void ProcessLetter(char letter)
        {
            letter = char.ToLower(letter);

            if (!correctGuesses.Contains(letter))
            {
                correctGuesses.Add(letter);

                if (!currentWord.Word.Contains(letter))
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
            foreach (char letter in currentWord.Word)
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

        private void pictureBox2_Click(object sender, EventArgs e)
        {

        }

    }
}