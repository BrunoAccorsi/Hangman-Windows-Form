namespace Hangman
{
    partial class Form1
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form1));
            btn_A = new Button();
            btn_B = new Button();
            btn_C = new Button();
            btn_Z = new Button();
            btn_Y = new Button();
            btn_X = new Button();
            btn_W = new Button();
            btn_V = new Button();
            btn_U = new Button();
            btn_T = new Button();
            btn_S = new Button();
            btn_R = new Button();
            btn_Q = new Button();
            btn_P = new Button();
            btn_O = new Button();
            btn_N = new Button();
            btn_M = new Button();
            btn_L = new Button();
            btn_K = new Button();
            btn_J = new Button();
            btn_I = new Button();
            btn_H = new Button();
            btn_G = new Button();
            btn_F = new Button();
            btn_E = new Button();
            btn_D = new Button();
            btn_newWord = new Button();
            btn_reset = new Button();
            lbl_win = new Label();
            lbl_number = new Label();
            lbl_x = new Label();
            lbl_used = new Label();
            pictureBox2 = new PictureBox();
            lbl_hint = new Label();
            ((System.ComponentModel.ISupportInitialize)pictureBox2).BeginInit();
            SuspendLayout();
            // 
            // btn_A
            // 
            btn_A.BackColor = Color.White;
            btn_A.Cursor = Cursors.Hand;
            btn_A.Location = new Point(211, 395);
            btn_A.Margin = new Padding(4, 3, 4, 3);
            btn_A.Name = "btn_A";
            btn_A.Size = new Size(47, 38);
            btn_A.TabIndex = 0;
            btn_A.Text = "A";
            btn_A.UseVisualStyleBackColor = false;
            btn_A.Click += btn_A_Click;
            // 
            // btn_B
            // 
            btn_B.Cursor = Cursors.Hand;
            btn_B.Location = new Point(264, 395);
            btn_B.Margin = new Padding(4, 3, 4, 3);
            btn_B.Name = "btn_B";
            btn_B.Size = new Size(47, 38);
            btn_B.TabIndex = 1;
            btn_B.Text = "B";
            btn_B.UseVisualStyleBackColor = true;
            btn_B.Click += btn_B_Click;
            // 
            // btn_C
            // 
            btn_C.Cursor = Cursors.Hand;
            btn_C.Location = new Point(318, 395);
            btn_C.Margin = new Padding(4, 3, 4, 3);
            btn_C.Name = "btn_C";
            btn_C.Size = new Size(47, 38);
            btn_C.TabIndex = 2;
            btn_C.Text = "C";
            btn_C.UseVisualStyleBackColor = true;
            btn_C.Click += btn_C_Click;
            // 
            // btn_Z
            // 
            btn_Z.Cursor = Cursors.Hand;
            btn_Z.Location = new Point(852, 440);
            btn_Z.Margin = new Padding(4, 3, 4, 3);
            btn_Z.Name = "btn_Z";
            btn_Z.Size = new Size(47, 38);
            btn_Z.TabIndex = 3;
            btn_Z.Text = "Z";
            btn_Z.UseVisualStyleBackColor = true;
            btn_Z.Click += btn_Z_Click;
            // 
            // btn_Y
            // 
            btn_Y.Cursor = Cursors.Hand;
            btn_Y.Location = new Point(799, 440);
            btn_Y.Margin = new Padding(4, 3, 4, 3);
            btn_Y.Name = "btn_Y";
            btn_Y.Size = new Size(47, 38);
            btn_Y.TabIndex = 4;
            btn_Y.Text = "Y";
            btn_Y.UseVisualStyleBackColor = true;
            btn_Y.Click += btn_Y_Click;
            // 
            // btn_X
            // 
            btn_X.Cursor = Cursors.Hand;
            btn_X.Location = new Point(745, 439);
            btn_X.Margin = new Padding(4, 3, 4, 3);
            btn_X.Name = "btn_X";
            btn_X.Size = new Size(47, 38);
            btn_X.TabIndex = 5;
            btn_X.Text = "X";
            btn_X.UseVisualStyleBackColor = true;
            btn_X.Click += btn_X_Click;
            // 
            // btn_W
            // 
            btn_W.Cursor = Cursors.Hand;
            btn_W.Location = new Point(691, 439);
            btn_W.Margin = new Padding(4, 3, 4, 3);
            btn_W.Name = "btn_W";
            btn_W.Size = new Size(47, 38);
            btn_W.TabIndex = 6;
            btn_W.Text = "W";
            btn_W.UseVisualStyleBackColor = true;
            btn_W.Click += btn_W_Click;
            // 
            // btn_V
            // 
            btn_V.Cursor = Cursors.Hand;
            btn_V.Location = new Point(638, 439);
            btn_V.Margin = new Padding(4, 3, 4, 3);
            btn_V.Name = "btn_V";
            btn_V.Size = new Size(47, 38);
            btn_V.TabIndex = 7;
            btn_V.Text = "V";
            btn_V.UseVisualStyleBackColor = true;
            btn_V.Click += btn_V_Click;
            // 
            // btn_U
            // 
            btn_U.Cursor = Cursors.Hand;
            btn_U.Location = new Point(584, 439);
            btn_U.Margin = new Padding(4, 3, 4, 3);
            btn_U.Name = "btn_U";
            btn_U.Size = new Size(47, 38);
            btn_U.TabIndex = 8;
            btn_U.Text = "U";
            btn_U.UseVisualStyleBackColor = true;
            btn_U.Click += btn_U_Click;
            // 
            // btn_T
            // 
            btn_T.Cursor = Cursors.Hand;
            btn_T.Location = new Point(533, 440);
            btn_T.Margin = new Padding(4, 3, 4, 3);
            btn_T.Name = "btn_T";
            btn_T.Size = new Size(47, 38);
            btn_T.TabIndex = 9;
            btn_T.Text = "T";
            btn_T.UseVisualStyleBackColor = true;
            btn_T.Click += btn_T_Click;
            // 
            // btn_S
            // 
            btn_S.Cursor = Cursors.Hand;
            btn_S.Location = new Point(479, 440);
            btn_S.Margin = new Padding(4, 3, 4, 3);
            btn_S.Name = "btn_S";
            btn_S.Size = new Size(47, 38);
            btn_S.TabIndex = 10;
            btn_S.Text = "S";
            btn_S.UseVisualStyleBackColor = true;
            btn_S.Click += btn_S_Click;
            // 
            // btn_R
            // 
            btn_R.Cursor = Cursors.Hand;
            btn_R.Location = new Point(425, 440);
            btn_R.Margin = new Padding(4, 3, 4, 3);
            btn_R.Name = "btn_R";
            btn_R.Size = new Size(47, 38);
            btn_R.TabIndex = 11;
            btn_R.Text = "R";
            btn_R.UseVisualStyleBackColor = true;
            btn_R.Click += btn_R_Click;
            // 
            // btn_Q
            // 
            btn_Q.Cursor = Cursors.Hand;
            btn_Q.Location = new Point(372, 440);
            btn_Q.Margin = new Padding(4, 3, 4, 3);
            btn_Q.Name = "btn_Q";
            btn_Q.Size = new Size(47, 38);
            btn_Q.TabIndex = 12;
            btn_Q.Text = "Q";
            btn_Q.UseVisualStyleBackColor = true;
            btn_Q.Click += btn_Q_Click;
            // 
            // btn_P
            // 
            btn_P.Cursor = Cursors.Hand;
            btn_P.Location = new Point(318, 440);
            btn_P.Margin = new Padding(4, 3, 4, 3);
            btn_P.Name = "btn_P";
            btn_P.Size = new Size(47, 38);
            btn_P.TabIndex = 13;
            btn_P.Text = "P";
            btn_P.UseVisualStyleBackColor = true;
            btn_P.Click += btn_P_Click;
            // 
            // btn_O
            // 
            btn_O.Cursor = Cursors.Hand;
            btn_O.Location = new Point(264, 440);
            btn_O.Margin = new Padding(4, 3, 4, 3);
            btn_O.Name = "btn_O";
            btn_O.Size = new Size(47, 38);
            btn_O.TabIndex = 14;
            btn_O.Text = "O";
            btn_O.UseVisualStyleBackColor = true;
            btn_O.Click += btn_O_Click;
            // 
            // btn_N
            // 
            btn_N.Cursor = Cursors.Hand;
            btn_N.Location = new Point(211, 440);
            btn_N.Margin = new Padding(4, 3, 4, 3);
            btn_N.Name = "btn_N";
            btn_N.Size = new Size(47, 38);
            btn_N.TabIndex = 15;
            btn_N.Text = "N";
            btn_N.UseVisualStyleBackColor = true;
            btn_N.Click += btn_N_Click;
            // 
            // btn_M
            // 
            btn_M.Cursor = Cursors.Hand;
            btn_M.Location = new Point(852, 395);
            btn_M.Margin = new Padding(4, 3, 4, 3);
            btn_M.Name = "btn_M";
            btn_M.Size = new Size(47, 38);
            btn_M.TabIndex = 16;
            btn_M.Text = "M";
            btn_M.UseVisualStyleBackColor = true;
            btn_M.Click += btn_M_Click;
            // 
            // btn_L
            // 
            btn_L.Cursor = Cursors.Hand;
            btn_L.Location = new Point(799, 395);
            btn_L.Margin = new Padding(4, 3, 4, 3);
            btn_L.Name = "btn_L";
            btn_L.Size = new Size(47, 38);
            btn_L.TabIndex = 17;
            btn_L.Text = "L";
            btn_L.UseVisualStyleBackColor = true;
            btn_L.Click += btn_L_Click;
            // 
            // btn_K
            // 
            btn_K.Cursor = Cursors.Hand;
            btn_K.Location = new Point(745, 395);
            btn_K.Margin = new Padding(4, 3, 4, 3);
            btn_K.Name = "btn_K";
            btn_K.Size = new Size(47, 38);
            btn_K.TabIndex = 18;
            btn_K.Text = "K";
            btn_K.UseVisualStyleBackColor = true;
            btn_K.Click += btn_K_Click;
            // 
            // btn_J
            // 
            btn_J.Cursor = Cursors.Hand;
            btn_J.Location = new Point(691, 395);
            btn_J.Margin = new Padding(4, 3, 4, 3);
            btn_J.Name = "btn_J";
            btn_J.Size = new Size(47, 38);
            btn_J.TabIndex = 19;
            btn_J.Text = "J";
            btn_J.UseVisualStyleBackColor = true;
            btn_J.Click += btn_J_Click;
            // 
            // btn_I
            // 
            btn_I.Cursor = Cursors.Hand;
            btn_I.Location = new Point(638, 395);
            btn_I.Margin = new Padding(4, 3, 4, 3);
            btn_I.Name = "btn_I";
            btn_I.Size = new Size(47, 38);
            btn_I.TabIndex = 20;
            btn_I.Text = "I";
            btn_I.UseVisualStyleBackColor = true;
            btn_I.Click += btn_I_Click;
            // 
            // btn_H
            // 
            btn_H.Cursor = Cursors.Hand;
            btn_H.Location = new Point(584, 394);
            btn_H.Margin = new Padding(4, 3, 4, 3);
            btn_H.Name = "btn_H";
            btn_H.Size = new Size(47, 38);
            btn_H.TabIndex = 21;
            btn_H.Text = "H";
            btn_H.UseVisualStyleBackColor = true;
            btn_H.Click += btn_H_Click;
            // 
            // btn_G
            // 
            btn_G.Cursor = Cursors.Hand;
            btn_G.Location = new Point(533, 394);
            btn_G.Margin = new Padding(4, 3, 4, 3);
            btn_G.Name = "btn_G";
            btn_G.Size = new Size(47, 38);
            btn_G.TabIndex = 22;
            btn_G.Text = "G";
            btn_G.UseVisualStyleBackColor = true;
            btn_G.Click += btn_G_Click;
            // 
            // btn_F
            // 
            btn_F.Cursor = Cursors.Hand;
            btn_F.Location = new Point(479, 395);
            btn_F.Margin = new Padding(4, 3, 4, 3);
            btn_F.Name = "btn_F";
            btn_F.Size = new Size(47, 38);
            btn_F.TabIndex = 23;
            btn_F.Text = "F";
            btn_F.UseVisualStyleBackColor = true;
            btn_F.Click += btn_F_Click;
            // 
            // btn_E
            // 
            btn_E.Cursor = Cursors.Hand;
            btn_E.Location = new Point(425, 395);
            btn_E.Margin = new Padding(4, 3, 4, 3);
            btn_E.Name = "btn_E";
            btn_E.Size = new Size(47, 38);
            btn_E.TabIndex = 24;
            btn_E.Text = "E";
            btn_E.UseVisualStyleBackColor = true;
            btn_E.Click += btn_E_Click;
            // 
            // btn_D
            // 
            btn_D.Cursor = Cursors.Hand;
            btn_D.Location = new Point(372, 395);
            btn_D.Margin = new Padding(4, 3, 4, 3);
            btn_D.Name = "btn_D";
            btn_D.Size = new Size(47, 38);
            btn_D.TabIndex = 25;
            btn_D.Text = "D";
            btn_D.UseVisualStyleBackColor = true;
            btn_D.Click += btn_D_Click;
            // 
            // btn_newWord
            // 
            btn_newWord.Cursor = Cursors.Hand;
            btn_newWord.Location = new Point(32, 379);
            btn_newWord.Margin = new Padding(4, 3, 4, 3);
            btn_newWord.Name = "btn_newWord";
            btn_newWord.Size = new Size(146, 38);
            btn_newWord.TabIndex = 26;
            btn_newWord.Text = "New Word";
            btn_newWord.UseVisualStyleBackColor = true;
            btn_newWord.Click += btn_newWord_Click;
            // 
            // btn_reset
            // 
            btn_reset.Cursor = Cursors.Hand;
            btn_reset.Location = new Point(32, 452);
            btn_reset.Margin = new Padding(4, 3, 4, 3);
            btn_reset.Name = "btn_reset";
            btn_reset.Size = new Size(146, 38);
            btn_reset.TabIndex = 27;
            btn_reset.Text = "Reset";
            btn_reset.UseVisualStyleBackColor = true;
            btn_reset.Click += btn_reset_Click;
            // 
            // lbl_win
            // 
            lbl_win.AutoSize = true;
            lbl_win.BackColor = Color.Transparent;
            lbl_win.Font = new Font("MV Boli", 20.25F, FontStyle.Bold, GraphicsUnit.Point, 0);
            lbl_win.ForeColor = Color.White;
            lbl_win.Location = new Point(757, 21);
            lbl_win.Margin = new Padding(4, 0, 4, 0);
            lbl_win.Name = "lbl_win";
            lbl_win.Size = new Size(76, 34);
            lbl_win.TabIndex = 29;
            lbl_win.Text = "Win:";
            // 
            // lbl_number
            // 
            lbl_number.AutoSize = true;
            lbl_number.BackColor = Color.Transparent;
            lbl_number.Font = new Font("MV Boli", 20.25F, FontStyle.Bold, GraphicsUnit.Point, 0);
            lbl_number.ForeColor = Color.White;
            lbl_number.Location = new Point(836, 21);
            lbl_number.Margin = new Padding(4, 0, 4, 0);
            lbl_number.Name = "lbl_number";
            lbl_number.Size = new Size(35, 34);
            lbl_number.TabIndex = 30;
            lbl_number.Text = "0";
            // 
            // lbl_x
            // 
            lbl_x.AutoSize = true;
            lbl_x.BackColor = Color.Transparent;
            lbl_x.Font = new Font("MV Boli", 20.25F, FontStyle.Regular, GraphicsUnit.Point, 0);
            lbl_x.ForeColor = Color.White;
            lbl_x.Location = new Point(872, 22);
            lbl_x.Margin = new Padding(4, 0, 4, 0);
            lbl_x.Name = "lbl_x";
            lbl_x.Size = new Size(28, 34);
            lbl_x.TabIndex = 31;
            lbl_x.Text = "x";
            // 
            // lbl_used
            // 
            lbl_used.AutoSize = true;
            lbl_used.BackColor = Color.Transparent;
            lbl_used.Font = new Font("MV Boli", 20.25F, FontStyle.Bold, GraphicsUnit.Point, 0);
            lbl_used.ForeColor = Color.White;
            lbl_used.Location = new Point(211, 294);
            lbl_used.Margin = new Padding(4, 0, 4, 0);
            lbl_used.Name = "lbl_used";
            lbl_used.Size = new Size(88, 34);
            lbl_used.TabIndex = 32;
            lbl_used.Text = "Used:";
            // 
            // pictureBox2
            // 
            pictureBox2.BackColor = Color.Transparent;
            pictureBox2.Location = new Point(32, 22);
            pictureBox2.Margin = new Padding(3, 2, 3, 2);
            pictureBox2.Name = "pictureBox2";
            pictureBox2.Size = new Size(231, 290);
            pictureBox2.SizeMode = PictureBoxSizeMode.AutoSize;
            pictureBox2.TabIndex = 33;
            pictureBox2.TabStop = false;
            pictureBox2.Click += pictureBox2_Click;
            // 
            // lbl_hint
            // 
            lbl_hint.AutoSize = true;
            lbl_hint.BackColor = Color.Transparent;
            lbl_hint.Font = new Font("MV Boli", 13.8F, FontStyle.Bold, GraphicsUnit.Point, 0);
            lbl_hint.ForeColor = Color.White;
            lbl_hint.Location = new Point(211, 363);
            lbl_hint.Margin = new Padding(4, 0, 4, 0);
            lbl_hint.Name = "lbl_hint";
            lbl_hint.Size = new Size(64, 25);
            lbl_hint.TabIndex = 35;
            lbl_hint.Text = "Hint:";
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.White;
            BackgroundImage = (Image)resources.GetObject("$this.BackgroundImage");
            ClientSize = new Size(933, 519);
            Controls.Add(lbl_hint);
            Controls.Add(lbl_used);
            Controls.Add(pictureBox2);
            Controls.Add(lbl_x);
            Controls.Add(lbl_number);
            Controls.Add(lbl_win);
            Controls.Add(btn_reset);
            Controls.Add(btn_newWord);
            Controls.Add(btn_D);
            Controls.Add(btn_E);
            Controls.Add(btn_F);
            Controls.Add(btn_G);
            Controls.Add(btn_H);
            Controls.Add(btn_I);
            Controls.Add(btn_J);
            Controls.Add(btn_K);
            Controls.Add(btn_L);
            Controls.Add(btn_M);
            Controls.Add(btn_N);
            Controls.Add(btn_O);
            Controls.Add(btn_P);
            Controls.Add(btn_Q);
            Controls.Add(btn_R);
            Controls.Add(btn_S);
            Controls.Add(btn_T);
            Controls.Add(btn_U);
            Controls.Add(btn_V);
            Controls.Add(btn_W);
            Controls.Add(btn_X);
            Controls.Add(btn_Y);
            Controls.Add(btn_Z);
            Controls.Add(btn_C);
            Controls.Add(btn_B);
            Controls.Add(btn_A);
            Margin = new Padding(4, 3, 4, 3);
            Name = "Form1";
            Text = "Form1";
            Load += Form1_Load;
            ((System.ComponentModel.ISupportInitialize)pictureBox2).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private System.Windows.Forms.Button btn_A;
        private System.Windows.Forms.Button btn_B;
        private System.Windows.Forms.Button btn_C;
        private System.Windows.Forms.Button btn_Z;
        private System.Windows.Forms.Button btn_Y;
        private System.Windows.Forms.Button btn_X;
        private System.Windows.Forms.Button btn_W;
        private System.Windows.Forms.Button btn_V;
        private System.Windows.Forms.Button btn_U;
        private System.Windows.Forms.Button btn_T;
        private System.Windows.Forms.Button btn_S;
        private System.Windows.Forms.Button btn_R;
        private System.Windows.Forms.Button btn_Q;
        private System.Windows.Forms.Button btn_P;
        private System.Windows.Forms.Button btn_O;
        private System.Windows.Forms.Button btn_N;
        private System.Windows.Forms.Button btn_M;
        private System.Windows.Forms.Button btn_L;
        private System.Windows.Forms.Button btn_K;
        private System.Windows.Forms.Button btn_J;
        private System.Windows.Forms.Button btn_I;
        private System.Windows.Forms.Button btn_H;
        private System.Windows.Forms.Button btn_G;
        private System.Windows.Forms.Button btn_F;
        private System.Windows.Forms.Button btn_E;
        private System.Windows.Forms.Button btn_D;
        private System.Windows.Forms.Button btn_newWord;
        private System.Windows.Forms.Button btn_reset;
        private System.Windows.Forms.Label lbl_win;
        private System.Windows.Forms.Label lbl_number;
        private System.Windows.Forms.Label lbl_x;
        private System.Windows.Forms.Label lbl_used;
        private PictureBox pictureBox2;
        private Label lbl_hint;
    }
}
    