using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace CollsionsCode
{
    public partial class Form1 : Form
    {

        //global variables
        int carSpeed = 8;
        int roadSpeed = 5;
        bool carLeft;
        bool carRight;
        int trafficSpeed = 5;
        int score = 0;
        Random rnd = new Random();

        public Form1()
        {
            InitializeComponent();
            Reset();
        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {

        }

        private void Explosion_Click(object sender, EventArgs e)
        {

        }

        private void Reset()
        {

            //reset values
            trophy.Visible = false;
            button1.Enabled = false;
            Explosion.Visible = false;
            trafficSpeed = 10;
            roadSpeed = 100;
            score = 0;
            Player.Left = 161;
            Player.Top = 286;
            carLeft = false;
            carRight = false;

            //AI default Position
            AI1.Left = 66;
            AI1.Top = -120;

            AI2.Left = 294;
            AI2.Top = -185;

            //track default position
            road2.Left = -3;
            road2.Top = -222;
            road1.Left = -2;
            road1.Top = -638;

            //start timer
            timer1.Start();
        }

        private void timer1_Tick(object sender, EventArgs e)
        {
            //code run each tick
            score++;

            Distance.Text = "" + score;

            road1.Top += roadSpeed;
            road2.Top += roadSpeed;

            //for when track runs out
            if (road1.Top > 630)
            {
                road1.Top = -630;
            }
            if (road2.Top > 630)
            {
                road2.Top = -630;
            }

            //end of track animation

            //car movement
            if (carLeft)
            { Player.Left -= carSpeed; }
            if (carRight)
            { Player.Left += carSpeed; }

            //end of player movement

            //keep player inside the boundries
            if (Player.Left < 1)
            {
                carLeft = false;
            }
            else if (Player.Left + Player.Width > 380)
            {
                carRight = false;
            }

            //end of boundries check

            //AI movement
            AI1.Top += trafficSpeed;
            AI2.Top += trafficSpeed;

            //respawn the AI
            if (AI1.Top > panel1.Height)
            {
                ChangeAI1(); //Function to change image
                AI1.Left = rnd.Next(2, 160);
                AI1.Top = rnd.Next(100, 200) * -1;

            }
            if (AI2.Top > panel1.Height)
            {
                ChangeAI2(); //Function to change image
                AI2.Left = rnd.Next(185, 327);
                AI2.Top = rnd.Next(100, 200) * -1;
            }
            //End of AI Respawn




            //Hit test player and AI
            //if statement is checking multiple conditions 
            //Player hits AI 1 or 2
            if (Player.Bounds.IntersectsWith(AI1.Bounds) || Player.Bounds.IntersectsWith(AI2.Bounds))
            {
                gameOver();
            }

            //speed up traffic
            //Do that later

        }

        private void moveCar(object sender, KeyEventArgs e)
        {
            //if the player pressed left key AND is inside the panel
            if (e.KeyCode == Keys.Left && Player.Left > 0)
            {
                carLeft = true;
            }

            //if player press right key and is inside the pannnel
            if (e.KeyCode == Keys.Right && Player.Left + Player.Width < panel1.Width)
            {
                carRight = true;
            }
        }
        private void stopCar(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Left)
            {
                carLeft = false;
            }
            if (e.KeyCode == Keys.Right)
            {
                carRight = false;
            }
        }

        private void ChangeAI1()
        {

        }
        private void ChangeAI2()
        {

        }

        private void gameOver()
        {
            trophy.Visible = true;
            timer1.Stop();
            button1.Enabled = true;



        }

        private void button1_Click(object sender, EventArgs e)
        {
            Reset();
        }
    }
}