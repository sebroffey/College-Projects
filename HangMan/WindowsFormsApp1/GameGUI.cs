using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WindowsFormsApp1
{
    public partial class GameGUI : Form
    {

        string positions;
        int position;
        char positionCHAR;
        string positionSTR;
        int wordLength;
        string letter;
        int revealedLetters = 0;

        string wordToBeGuessed;
        
        char letter1;
        char letter2;
        char letter3;
        char letter4;
        char letter5;
        char letter6;
        char letter7;
        char letter8;

        int validGuess;

        int score = 0;

        public GameGUI(string player1)
        {
            InitializeComponent();

            //Show player name in label
            player1 = "Welcome, " + player1;
            playerName.Text = player1;


            //Hide Hangman

            panel1.Visible = false;
            panel2.Visible = false;
            panel3.Visible = false;
            panel4.Visible = false;
            panel5.Visible = false;
            looserLabel1.Visible = false;
            looserLabel2.Visible = false;
            winnerLabel1.Visible = false;
            winnerLabel2.Visible = false;
            winnerLabel3.Visible = false;
            lettersGuessedLabel.Text = "";
            

            //Functions in class can be refered too by "game."
            GameModel game = new GameModel();
          
            wordToBeGuessed = game.genWord();           
            wordLength = wordToBeGuessed.Length;

            //CH1 - CH8 loop into gui
            for (int index = 0; index <= 7; index++)
            {
                switch (index)
                {
                    //First Letter
                    case 0:

                        if (wordLength <= index)
                        {
                            letter1 = '_';
                            CH1.Text = "";
                        }
                        else
                        {
                            letter1 = wordToBeGuessed[index];
                            CH1.Text = "_";

                        }
                       
                        break;
                    //Second letter
                    case 1:

                        if (wordLength <= index)
                        {
                            letter2 = '_';
                            CH2.Text = "";
                        }
                        else
                        {
                            letter2 = wordToBeGuessed[index];
                            CH2.Text = "_";

                        }

                        break;
                    //Third Letter
                    case 2:

                        if (wordLength <= index)
                        {
                            letter3 = '_';
                            CH3.Text = "";
                        }
                        else
                        {
                            letter3 = wordToBeGuessed[index];
                            CH3.Text = "_";

                        }

                        break;
                    //Forth Letter
                    case 3:

                        if (wordLength <= index)
                        {
                            letter4 = '_';
                            CH4.Text = "";
                        }
                        else
                        {
                            letter4 = wordToBeGuessed[index];
                            CH4.Text = "_";

                        }

                        break;
                    //Fith Letter
                    case 4:

                        if (wordLength <= index)
                        {
                            letter5 = '_';
                            CH5.Text = "";
                        }
                        else
                        {
                            letter5 = wordToBeGuessed[index];
                            CH5.Text = "_";

                        }

                        break;
                    //Sixth Letter
                    case 5:

                        if (wordLength <= index)
                        {
                            letter6 = '_';
                            CH6.Text = "";
                        }
                        else
                        {
                            letter6 = wordToBeGuessed[index];
                            CH6.Text = "_";

                        }

                        break;
                    //Seventh Letter
                    case 6:

                        if (wordLength <= index)
                        {
                            letter7 = '_';
                            CH7.Text = "";
                        }
                        else
                        {
                            letter7 = wordToBeGuessed[index];
                            CH7.Text = "_";

                        }

                        break;
                    //Eigth Letter
                    case 7:

                        if (wordLength <= index)
                        {
                            letter8 = '_';
                            CH8.Text = "";
                        }
                        else
                        {
                            letter8 = wordToBeGuessed[index];
                            CH8.Text = "_";

                        }

                        break;
                }                        
            }
        }
        //Procedure for when a button is clicked:

        public void letterProcedure(string letter)
        {
            //Why does this have to be here again?
            //
            GameModel game = new GameModel();
            //
            //Check mode int = 0, Function checks to see if letter is present, and int is returned
            //reperesenting how many times the letter appears in the word.
            validGuess = Convert.ToInt32(game.checkGuess(letter, 0, wordToBeGuessed));
            revealedLetters = revealedLetters + validGuess;

            if (validGuess >= 1)
            {

                //Positions is a string with each letter reperesenting a letters location.
                positions = game.checkGuess(letter, 1, wordToBeGuessed);

                for (int index = 0; index < validGuess; index++)
                {
                    //For the position of each letter repeated or not to reveal in the GUI.

                    positionCHAR = positions[index];
                    positionSTR = positionCHAR.ToString();
                    position = Convert.ToInt32(positionSTR);

                    switch (position)
                    {

                        case 0:

                            CH1.Text = letter;

                            break;

                        case 1:

                            CH2.Text = letter;

                            break;

                        case 2:

                            CH3.Text = letter;

                            break;
                        case 3:

                            CH4.Text = letter;

                            break;

                        case 4:

                            CH5.Text = letter;

                            break;

                        case 5:

                            CH6.Text = letter;
                            break;

                        case 6:

                            CH7.Text = letter;

                            break;

                        case 7:

                            CH8.Text = letter;

                            break;
                    }
                }
                
                //Check for a win                                     
                if (revealedLetters == wordLength)
                {

                    //CODE FOR A WIN
                    winnerLabel1.Visible = true;
                    winnerLabel2.Visible = true;
                    winnerLabel3.Visible = true;

                    M.Visible = false;
                    N.Visible = false;
                    B.Visible = false;
                    V.Visible = false;
                    C.Visible = false;
                    X.Visible = false;
                    Z.Visible = false;
                    L.Visible = false;
                    K.Visible = false;
                    J.Visible = false;
                    H.Visible = false;
                    F.Visible = false;
                    D.Visible = false;
                    S.Visible = false;
                    A.Visible = false;
                    G.Visible = false;
                    P.Visible = false;
                    O.Visible = false;
                    I.Visible = false;
                    U.Visible = false;
                    Y.Visible = false;
                    T.Visible = false;
                    R.Visible = false;
                    E.Visible = false;
                    W.Visible = false;
                    Q.Visible = false;
                }
            }

            //If the letter is not present:
            else
            {
                score = score + 1;
                if (score == 5)
                {
                    //Code for YOU LOOSE
                    looserLabel1.Visible = true;
                    looserLabel2.Visible = true;
                    panel5.Visible = true;

                    M.Visible = false;
                    N.Visible = false;
                    B.Visible = false;
                    V.Visible = false;
                    C.Visible = false;
                    X.Visible = false;
                    Z.Visible = false;
                    L.Visible = false;
                    K.Visible = false;
                    J.Visible = false;
                    H.Visible = false;
                    F.Visible = false;
                    D.Visible = false;
                    S.Visible = false;
                    A.Visible = false;
                    G.Visible = false;
                    P.Visible = false;
                    O.Visible = false;
                    I.Visible = false;
                    U.Visible = false;
                    Y.Visible = false;
                    T.Visible = false;
                    R.Visible = false;
                    E.Visible = false;
                    W.Visible = false;
                    Q.Visible = false;  
                }

                else
                {
                    switch (score)
                    {

                        case 1:

                            panel1.Visible = true;

                            break;

                        case 2:

                            panel2.Visible = true;

                            break;

                        case 3:

                            panel3.Visible = true;

                            break;

                        case 4:

                            panel4.Visible = true;

                            break;
                    }

                }

            }

        }

        //When Buttons Are Clicked:
        private void A_Click(object sender, EventArgs e)
        {
            //Outside Function Porceedures
            A.Visible = false;
            lettersGuessedLabel.Text = lettersGuessedLabel.Text + "A ";
            letter = "A";

            letterProcedure(letter);          
        }
        

        private void B_Click_1(object sender, EventArgs e)
        {
            //Outside Function Porceedures
            B.Visible = false;
            lettersGuessedLabel.Text = lettersGuessedLabel.Text + "B ";
            letter = "B";

            letterProcedure(letter);
        }

        private void C_Click_1(object sender, EventArgs e)
        {
            //Outside Function Porceedures
            C.Visible = false;
            lettersGuessedLabel.Text = lettersGuessedLabel.Text + "C ";
            letter = "C";

            letterProcedure(letter);
        }

        private void D_Click_1(object sender, EventArgs e)
        {
            //Outside Function Porceedures
            D.Visible = false;
            lettersGuessedLabel.Text = lettersGuessedLabel.Text + "D ";
            letter = "D";

            letterProcedure(letter);
        }

        private void E_Click_1(object sender, EventArgs e)
        {
            //Outside Function Porceedures
            E.Visible = false;
            lettersGuessedLabel.Text = lettersGuessedLabel.Text + "E ";
            letter = "E";

            letterProcedure(letter);
        }

        private void F_Click_1(object sender, EventArgs e)
        {
            //Outside Function Porceedures
            F.Visible = false;
            lettersGuessedLabel.Text = lettersGuessedLabel.Text + "F ";
            letter = "F";

            letterProcedure(letter);
        }
        private void button18_Click(object sender, EventArgs e)
        {
            //DUNNO WHY THIS IS G
            G.Visible = false;
            lettersGuessedLabel.Text = lettersGuessedLabel.Text + "G ";
            letter = "G";

            letterProcedure(letter);

        }

        private void H_Click_1(object sender, EventArgs e)
        {
            //Outside Function Porceedures
            H.Visible = false;
            lettersGuessedLabel.Text = lettersGuessedLabel.Text + "H ";
            letter = "H";

            letterProcedure(letter);
        }

        private void I_Click_1(object sender, EventArgs e)
        {
            //Outside Function Porceedures
            I.Visible = false;
            lettersGuessedLabel.Text = lettersGuessedLabel.Text + "I ";
            letter = "I";

            letterProcedure(letter);
        }

        private void J_Click_1(object sender, EventArgs e)
        {
            //Outside Function Porceedures
            J.Visible = false;
            lettersGuessedLabel.Text = lettersGuessedLabel.Text + "J ";
            letter = "J";

            letterProcedure(letter);
        }

        private void K_Click_1(object sender, EventArgs e)
        {
            //Outside Function Porceedures
            K.Visible = false;
            lettersGuessedLabel.Text = lettersGuessedLabel.Text + "K ";
            letter = "K";

            letterProcedure(letter);
        }

        private void L_Click_1(object sender, EventArgs e)
        {
            //Outside Function Porceedures
            L.Visible = false;
            lettersGuessedLabel.Text = lettersGuessedLabel.Text + "L ";
            letter = "L";

            letterProcedure(letter);
        }

        private void M_Click_1(object sender, EventArgs e)
        {
            //Outside Function Porceedures
            M.Visible = false;
            lettersGuessedLabel.Text = lettersGuessedLabel.Text + "M ";
            letter = "M";

            letterProcedure(letter);
        }

        private void N_Click_1(object sender, EventArgs e)
        {
            //Outside Function Porceedures
            N.Visible = false;
            lettersGuessedLabel.Text = lettersGuessedLabel.Text + "N ";
            letter = "N";

            letterProcedure(letter);
        }

        private void O_Click_1(object sender, EventArgs e)
        {
            //Outside Function Porceedures
            O.Visible = false;
            lettersGuessedLabel.Text = lettersGuessedLabel.Text + "O ";
            letter = "O";

            letterProcedure(letter);
        }

        private void P_Click_1(object sender, EventArgs e)
        {
            //Outside Function Porceedures
            P.Visible = false;
            lettersGuessedLabel.Text = lettersGuessedLabel.Text + "P ";
            letter = "P";

            letterProcedure(letter);
        }

        private void Q_Click_1(object sender, EventArgs e)
        {
            //Outside Function Porceedures
            Q.Visible = false;
            lettersGuessedLabel.Text = lettersGuessedLabel.Text + "Q ";
            letter = "Q";

            letterProcedure(letter);
        }

        private void R_Click_1(object sender, EventArgs e)
        {
            //Outside Function Porceedures
            R.Visible = false;
            lettersGuessedLabel.Text = lettersGuessedLabel.Text + "R ";
            letter = "R";

            letterProcedure(letter);
        }

        private void S_Click_1(object sender, EventArgs e)
        {
            //Outside Function Porceedures
            S.Visible = false;
            lettersGuessedLabel.Text = lettersGuessedLabel.Text + "S ";
            letter = "S";

            letterProcedure(letter);
        }

        private void T_Click_1(object sender, EventArgs e)
        {
            //Outside Function Porceedures
            T.Visible = false;
            lettersGuessedLabel.Text = lettersGuessedLabel.Text + "T ";
            letter = "T";

            letterProcedure(letter);
        }

        private void U_Click_1(object sender, EventArgs e)
        {
            //Outside Function Porceedures
            U.Visible = false;
            lettersGuessedLabel.Text = lettersGuessedLabel.Text + "U ";
            letter = "U";

            letterProcedure(letter);
        }

        private void V_Click_1(object sender, EventArgs e)
        {
            //Outside Function Porceedures
            V.Visible = false;
            lettersGuessedLabel.Text = lettersGuessedLabel.Text + "V ";
            letter = "V";

            letterProcedure(letter);
        }

        private void W_Click_1(object sender, EventArgs e)
        {
            //Outside Function Porceedures
            W.Visible = false;
            lettersGuessedLabel.Text = lettersGuessedLabel.Text + "W ";
            letter = "W";

            letterProcedure(letter);
        }

        private void X_Click_1(object sender, EventArgs e)
        {
            //Outside Function Porceedures
            X.Visible = false;
            lettersGuessedLabel.Text = lettersGuessedLabel.Text + "X ";
            letter = "X";

            letterProcedure(letter);
        }

        private void Y_Click_1(object sender, EventArgs e)
        {
            //Outside Function Porceedures
            Y.Visible = false;
            lettersGuessedLabel.Text = lettersGuessedLabel.Text + "Y ";
            letter = "Y";

            letterProcedure(letter);
        }

        private void Z_Click_1(object sender, EventArgs e)
        {
            //Outside Function Porceedures
            Z.Visible = false;
            lettersGuessedLabel.Text = lettersGuessedLabel.Text + "Z ";
            letter = "Z";

            letterProcedure(letter);
        }



        private void GameGUI_Load(object sender, EventArgs e)
        {
            //Ignore
        }

        private void playerName_Click(object sender, EventArgs e)
        {
            //Ignore.
        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {
            //Ignore
        }

    }
}
