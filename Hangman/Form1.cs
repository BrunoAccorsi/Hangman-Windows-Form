using System.Net.Mail;

namespace Hangman
{
    public partial class Form1 : Form
    {
        private Gallow gallow;
        private (string Word, string Hint) currentWord;
        private List<char> correctGuesses;
        private int wrongGuesses;
        //Add counter
        private int winCount = 0;

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
            RestoreButtons();
            //Updates counter when starting
            lbl_number.Text = $"{winCount}";
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

        // Restore the letter buttons to their default state
        private void RestoreButtons()
        {
            foreach (Control control in Controls)
            {
                if (control is Button button)
                {
                    button.BackColor = Color.White;
                }
            }
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
        private void ProcessLetter(char letter, Button sender)
        {
            sender.BackColor = Color.DimGray;
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
                    ResetCount();
                    StartNewGame();

                }
                else if (IsWordGuessed())
                {
                    MessageBox.Show("Congratulations! You won!");
                    //Incrementing winCount
                    winCount++;
                    lbl_number.Text = $"{winCount}";
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
            ProcessLetter('A', (Button)sender);
        }

        private void btn_B_Click(object sender, EventArgs e)
        {
            ProcessLetter('B', (Button)sender);
        }

        private void btn_C_Click(object sender, EventArgs e)
        {
            ProcessLetter('C', (Button)sender);
        }

        private void btn_D_Click(object sender, EventArgs e)
        {
            ProcessLetter('D', (Button)sender);
        }

        private void btn_E_Click(object sender, EventArgs e)
        {
            ProcessLetter('E', (Button)sender);
        }

        // Repeat for letters F through Z
        private void btn_F_Click(object sender, EventArgs e)
        {
            ProcessLetter('F', (Button)sender);
        }

        private void btn_G_Click(object sender, EventArgs e)
        {
            ProcessLetter('G', (Button)sender);
        }

        private void btn_H_Click(object sender, EventArgs e)
        {
            ProcessLetter('H', (Button)sender);
        }

        private void btn_I_Click(object sender, EventArgs e)
        {
            ProcessLetter('I', (Button)sender);
        }

        private void btn_J_Click(object sender, EventArgs e)
        {
            ProcessLetter('J', (Button)sender);
        }

        private void btn_K_Click(object sender, EventArgs e)
        {
            ProcessLetter('K', (Button)sender);
        }

        private void btn_L_Click(object sender, EventArgs e)
        {
            ProcessLetter('L', (Button)sender);
        }

        private void btn_M_Click(object sender, EventArgs e)
        {
            ProcessLetter('M', (Button)sender);
        }

        private void btn_N_Click(object sender, EventArgs e)
        {
            ProcessLetter('N', (Button)sender);
        }

        private void btn_O_Click(object sender, EventArgs e)
        {
            ProcessLetter('O', (Button)sender);
        }

        private void btn_P_Click(object sender, EventArgs e)
        {
            ProcessLetter('P', (Button)sender);
        }

        private void btn_Q_Click(object sender, EventArgs e)
        {
            ProcessLetter('Q', (Button)sender);
        }

        private void btn_R_Click(object sender, EventArgs e)
        {
            ProcessLetter('R', (Button)sender);
        }

        private void btn_S_Click(object sender, EventArgs e)
        {
            ProcessLetter('S', (Button)sender);
        }

        private void btn_T_Click(object sender, EventArgs e)
        {
            ProcessLetter('T', (Button)sender);
        }

        private void btn_U_Click(object sender, EventArgs e)
        {
            ProcessLetter('U', (Button)sender);
        }

        private void btn_V_Click(object sender, EventArgs e)
        {
            ProcessLetter('V', (Button)sender);
        }

        private void btn_W_Click(object sender, EventArgs e)
        {
            ProcessLetter('W', (Button)sender);
        }

        private void btn_X_Click(object sender, EventArgs e)
        {
            ProcessLetter('X', (Button)sender);
        }

        private void btn_Y_Click(object sender, EventArgs e)
        {
            ProcessLetter('Y', (Button)sender);
        }

        private void btn_Z_Click(object sender, EventArgs e)
        {
            ProcessLetter('Z', (Button)sender);
        }

        // Event handlers to choose a new word
        private void btn_newWord_Click(object sender, EventArgs e)
        {
            StartNewGame();
        }

        // Event handler to reset the game
       
        private void ResetCount()
        {
            winCount = 0;
            lbl_number.Text = $"{winCount}";
        }
        private void btn_reset_Click(object sender, EventArgs e)
        {
            ResetCount();
            
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