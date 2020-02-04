using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WindowsFormsApp1
{
    class GameModel
    {

        



            
        int wordLength;
        


        

        Random rnd = new Random();
        public string genWord()
        {
            //Code to generate word which is pulled into program.
            //Pull from textfile in future

            //For now, using array of pre defined words.
            string[] words = new string[] { "BOSSMANS","SEB","EMMA","MARK","JAMES","HEREFORD","HSFC","MORRIES","KFC","SPOONS","MACCIES","BRIDGE","SANITISE","SADNESS" };
            int wordIndex = rnd.Next(0, words.Length);
            string generatedWord = words[wordIndex];

            //wordToBeGuesses used as can't index parameters in validGuess()
            //wordToBeGuessed = generatedWord;
            //wordLength = wordToBeGuessed.Length;


            return generatedWord;
        }


        public string checkGuess(string letter,int mode,string wordToBeGuessed)

            //Mode Dictates what the function is gonna do.
        {
            
            int validGuess = 0;
            string positions = "";
            wordLength = wordToBeGuessed.Length;

            for (int index = 0; index <= wordLength - 1; index++)
            {

                //TOOK AGES TO FIGURE THIS OUT
                //Probably should find better way to impliment this.

                char compareCH = wordToBeGuessed[index];
                string compareLetter = compareCH.ToString();


                if (compareLetter == letter)
                {
                    //Varying output depending on mode given.

                    if (mode == 0)
                    {
                        validGuess = validGuess + 1;
                    }

                    if (mode == 1)
                    {
                        positions = positions + index.ToString();
                    }
                    //Tried to find a way of pulling the location of the letter (index) out of the function.
                }
                
            }

            //validGuess reperesents the amount of times the guessed letter appeares in the word.

            if (mode == 0)
            {
                return validGuess.ToString();
            }
            if (mode == 1)
            {
                return positions;
            }
            return "";    
            
        }


        //Check Win Function

        public int checkWin(int guessedLetterNumber, string wordToBeGuessed, int revealedLetters)
        {
            revealedLetters = revealedLetters + guessedLetterNumber;
            wordLength = wordToBeGuessed.Length;

            if (revealedLetters == wordLength)
            {
                return 1;
                //Win Detected

            }
            else
            {
                return 0;

            }


            

        } 





    }
}
