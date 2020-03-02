using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing.Drawing2D;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Resources;


namespace Prototype1
{
    public partial class Form1 : Form
    {

        Random rnd = new Random();  //Creates instance of random type.
        int spawnEnemy = 0;
                                    //Declaring these variables so they can be used thoughout the form.
        private bool plot = false;


        //Creates needed instances of classes
        private ClassCurve Curve1 = new ClassCurve();
        Unit U1 = new Unit();
        Unit U2 = new Unit();
        Unit U3 = new Unit();
        Unit U4 = new Unit();
        Unit U5 = new Unit();
        Unit U6 = new Unit();
        Unit U7 = new Unit();
        Unit U8 = new Unit();
        Unit U9 = new Unit();
        Unit U0 = new Unit();

        Point nul = new Point(0, 0);

        GameModel Game1 = new GameModel();
        int currentUnitNumber = 0;
        int[] arrayOfDistances = new int[] { 0, 0, 0, 0, 0, 0, 0, 0, 0 };

        //Creating the form
        public Form1()
        {
            //Initializing the instance of the form and activating double buffering.
            InitializeComponent();
            DoubleBuffered = true;

            //Creates drawLine and causes it to be redrawn after every form refresh.
            this.Paint += new PaintEventHandler(drawLine);

            //Starts the timer which units will move in time.
            timer1.Start();
            WinLoose.Visible = false;

            //Causes all dictated paint values to be called
            plot = true;
            Curve1.generateRandom();

            //reset all units by calling unit death on all unit instances.
            U0.unitDeath(Game1, 0);
            U1.unitDeath(Game1, 0);
            U2.unitDeath(Game1, 0);
            U3.unitDeath(Game1, 0);
            U4.unitDeath(Game1, 0);
            U5.unitDeath(Game1, 0);
            U6.unitDeath(Game1, 0);
            U7.unitDeath(Game1, 0);
            U8.unitDeath(Game1, 0);
            U9.unitDeath(Game1, 0);

            Game1.restartInstance();

            //refresh form
            this.Refresh();
    
            label7.Visible = false;
            label8.Visible = false;
            Play.Visible = false;

            TankHover.Visible = false;
            GunCarHover.Visible = false;
            RocketTruckHover.Visible = false;
            HumveeHover.Visible = false;
            label9.Visible = false;

        }

        //Drawing the curve proceedure, using the curve class.
        private void drawLine(object sender, PaintEventArgs e)
        {
            if (plot)
            {
                // Create pens.
                Pen brownPen = new Pen(Color.OrangeRed, 3);
                Pen greenPen = new Pen(Color.Green, 3);

                //Puts data into ClassCurve
                Curve1.Draw(e.Graphics, greenPen);
                Background.SendToBack();
                Background.Hide();

            }
        }

        //Reset Button Click
        private void button1_Click(object sender, EventArgs e)
        {

            //Causes all dictated paint values to be called
            plot = true;
            Curve1.generateRandom();

            //reset all units by calling unit death on all unit instances.
            U0.unitDeath(Game1, 0);
            U1.unitDeath(Game1, 0);
            U2.unitDeath(Game1, 0);
            U3.unitDeath(Game1, 0);
            U4.unitDeath(Game1, 0);
            U5.unitDeath(Game1, 0);
            U6.unitDeath(Game1, 0);
            U7.unitDeath(Game1, 0);
            U8.unitDeath(Game1, 0);
            U9.unitDeath(Game1, 0);

            Game1.restartInstance();

            timer1.Start();
            //refresh form
            this.Refresh();
        }

        //Run every time the timer ticks
        private void timer1_Tick(object sender, EventArgs e)
        {
    
            Game1.checkUnitLocations(U0,U1,U2,U3,U4,U5,U6,U7,U8,U9);

            //If the unit shows to move is valid
            if (U0.getvalid() == true)
            {
                //Calls the function that moves the unit within the units class
                U0.moveUnit(Curve1.getPoints(), this);
                Game1.setNewUnitLocation(U0.getUnitArrayPosition(), U0.getUnitLocation());

            }

            if (U1.getvalid() == true)
            {
                //Calls the function that moves the unit within the units class
                U1.moveUnit(Curve1.getPoints(), this);
                Game1.setNewUnitLocation(U1.getUnitArrayPosition(), U1.getUnitLocation());
            }

            if (U2.getvalid() == true)
            {
                //Calls the function that moves the unit within the units class
                U2.moveUnit(Curve1.getPoints(), this);
                Game1.setNewUnitLocation(U2.getUnitArrayPosition(), U2.getUnitLocation());
            }

            if (U3.getvalid() == true)
            {
                //Calls the function that moves the unit within the units class
                U3.moveUnit(Curve1.getPoints(), this);
                Game1.setNewUnitLocation(U3.getUnitArrayPosition(), U3.getUnitLocation());
            }

            if (U4.getvalid() == true)
            {
                //Calls the function that moves the unit within the units class
                U4.moveUnit(Curve1.getPoints(), this);
                Game1.setNewUnitLocation(U4.getUnitArrayPosition(), U4.getUnitLocation());
            }

            if (U5.getvalid() == true)
            {
                //Calls the function that moves the unit within the units class
                U5.moveUnit(Curve1.getPoints(), this);
                Game1.setNewUnitLocation(U5.getUnitArrayPosition(), U5.getUnitLocation());
            }

            if (U6.getvalid() == true)
            {
                //Calls the function that moves the unit within the units class
                U6.moveUnit(Curve1.getPoints(), this);
                Game1.setNewUnitLocation(U6.getUnitArrayPosition(), U6.getUnitLocation());
            }

            if (U7.getvalid() == true)
            {
                //Calls the function that moves the unit within the units class
                U7.moveUnit(Curve1.getPoints(), this);
                Game1.setNewUnitLocation(U7.getUnitArrayPosition(), U7.getUnitLocation());
            }

            if (U8.getvalid() == true)
            {
                //Calls the function that moves the unit within the units class
                U8.moveUnit(Curve1.getPoints(), this);
                Game1.setNewUnitLocation(U8.getUnitArrayPosition(), U8.getUnitLocation());
            }

            if (U9.getvalid() == true)
            {
                //Calls the function that moves the unit within the units class
                U9.moveUnit(Curve1.getPoints(), this);
                Game1.setNewUnitLocation(U9.getUnitArrayPosition(), U9.getUnitLocation());
            }

            //Collision detection per tick per unit starting with U0:

            //Unit 1
            Game1.collisionExecute(U0, U1, U2, U3, U4, U5, U6, U7, U8, U9);
            Game1.collisionExecute(U0, U2, U1, U3, U4, U5, U6, U7, U8, U9);
            Game1.collisionExecute(U0, U3, U2, U1, U4, U5, U6, U7, U8, U9);
            Game1.collisionExecute(U0, U4, U2, U3, U1, U5, U6, U7, U8, U9);
            Game1.collisionExecute(U0, U5, U2, U3, U4, U1, U6, U7, U8, U9);
            Game1.collisionExecute(U0, U6, U2, U3, U4, U5, U1, U7, U8, U9);
            Game1.collisionExecute(U0, U7, U2, U3, U4, U5, U6, U1, U8, U9);
            Game1.collisionExecute(U0, U8, U2, U3, U4, U5, U6, U7, U1, U9);
            Game1.collisionExecute(U0, U9, U2, U3, U4, U5, U6, U7, U8, U1);

            //Unit 2
            Game1.collisionExecute(U1, U0, U2, U3, U4, U5, U6, U7, U8, U9);
            Game1.collisionExecute(U1, U2, U0, U3, U4, U5, U6, U7, U8, U9);
            Game1.collisionExecute(U1, U3, U2, U0, U4, U5, U6, U7, U8, U9);
            Game1.collisionExecute(U1, U4, U2, U3, U0, U5, U6, U7, U8, U9);
            Game1.collisionExecute(U1, U5, U2, U3, U4, U0, U6, U7, U8, U9);
            Game1.collisionExecute(U1, U6, U2, U3, U4, U5, U0, U7, U8, U9);
            Game1.collisionExecute(U1, U7, U2, U3, U4, U5, U6, U0, U8, U9);
            Game1.collisionExecute(U1, U8, U2, U3, U4, U5, U6, U7, U0, U9);
            Game1.collisionExecute(U1, U9, U2, U3, U4, U5, U6, U7, U8, U0);

            //Unit 3
            Game1.collisionExecute(U2, U0, U1, U3, U4, U5, U6, U7, U8, U9);
            Game1.collisionExecute(U2, U1, U0, U3, U4, U5, U6, U7, U8, U9);
            Game1.collisionExecute(U2, U3, U1, U0, U4, U5, U6, U7, U8, U9);
            Game1.collisionExecute(U2, U4, U1, U3, U0, U5, U6, U7, U8, U9);
            Game1.collisionExecute(U2, U5, U1, U3, U4, U0, U6, U7, U8, U9);
            Game1.collisionExecute(U2, U6, U1, U3, U4, U5, U0, U7, U8, U9);
            Game1.collisionExecute(U2, U7, U1, U3, U4, U5, U6, U0, U8, U9);
            Game1.collisionExecute(U2, U8, U1, U3, U4, U5, U6, U7, U0, U9);
            Game1.collisionExecute(U2, U9, U1, U3, U4, U5, U6, U7, U8, U0);

            //Unit 4
            Game1.collisionExecute(U3, U0, U1, U2, U4, U5, U6, U7, U8, U9);
            Game1.collisionExecute(U3, U1, U0, U2, U4, U5, U6, U7, U8, U9);
            Game1.collisionExecute(U3, U2, U1, U0, U4, U5, U6, U7, U8, U9);
            Game1.collisionExecute(U3, U4, U1, U2, U0, U5, U6, U7, U8, U9);
            Game1.collisionExecute(U3, U5, U1, U2, U4, U0, U6, U7, U8, U9);
            Game1.collisionExecute(U3, U6, U1, U2, U4, U5, U0, U7, U8, U9);
            Game1.collisionExecute(U3, U7, U1, U2, U4, U5, U6, U0, U8, U9);
            Game1.collisionExecute(U3, U8, U1, U2, U4, U5, U6, U7, U0, U9);
            Game1.collisionExecute(U3, U9, U1, U2, U4, U5, U6, U7, U8, U0);

            //Unit 5
            Game1.collisionExecute(U4, U0, U1, U2, U3, U5, U6, U7, U8, U9);
            Game1.collisionExecute(U4, U1, U0, U2, U3, U5, U6, U7, U8, U9);
            Game1.collisionExecute(U4, U2, U1, U0, U3, U5, U6, U7, U8, U9);
            Game1.collisionExecute(U4, U3, U1, U2, U0, U5, U6, U7, U8, U9);
            Game1.collisionExecute(U4, U5, U1, U2, U3, U0, U6, U7, U8, U9);
            Game1.collisionExecute(U4, U6, U1, U2, U3, U5, U0, U7, U8, U9);
            Game1.collisionExecute(U4, U7, U1, U2, U3, U5, U6, U0, U8, U9);
            Game1.collisionExecute(U4, U8, U1, U2, U3, U5, U6, U7, U0, U9);
            Game1.collisionExecute(U4, U9, U1, U2, U3, U5, U6, U7, U8, U0);

            //Unit 6
            Game1.collisionExecute(U5, U0, U1, U2, U3, U4, U6, U7, U8, U9);
            Game1.collisionExecute(U5, U1, U0, U2, U3, U4, U6, U7, U8, U9);
            Game1.collisionExecute(U5, U2, U1, U0, U3, U4, U6, U7, U8, U9);
            Game1.collisionExecute(U5, U3, U1, U2, U0, U4, U6, U7, U8, U9);
            Game1.collisionExecute(U5, U4, U1, U2, U3, U0, U6, U7, U8, U9);
            Game1.collisionExecute(U5, U6, U1, U2, U3, U4, U0, U7, U8, U9);
            Game1.collisionExecute(U5, U7, U1, U2, U3, U4, U6, U0, U8, U9);
            Game1.collisionExecute(U5, U8, U1, U2, U3, U4, U6, U7, U0, U9);
            Game1.collisionExecute(U5, U9, U1, U2, U3, U4, U6, U7, U8, U0);

            //Unit 7
            Game1.collisionExecute(U6, U0, U1, U2, U3, U4, U5, U7, U8, U9);
            Game1.collisionExecute(U6, U1, U0, U2, U3, U4, U5, U7, U8, U9);
            Game1.collisionExecute(U6, U2, U1, U0, U3, U4, U5, U7, U8, U9);
            Game1.collisionExecute(U6, U3, U1, U2, U0, U4, U5, U7, U8, U9);
            Game1.collisionExecute(U6, U4, U1, U2, U3, U0, U5, U7, U8, U9);
            Game1.collisionExecute(U6, U5, U1, U2, U3, U4, U0, U7, U8, U9);
            Game1.collisionExecute(U6, U7, U1, U2, U3, U4, U5, U0, U8, U9);
            Game1.collisionExecute(U6, U8, U1, U2, U3, U4, U5, U7, U0, U9);
            Game1.collisionExecute(U6, U9, U1, U2, U3, U4, U5, U7, U8, U0);

            //Unit 8
            Game1.collisionExecute(U7, U0, U1, U2, U3, U4, U5, U6, U8, U9);
            Game1.collisionExecute(U7, U1, U0, U2, U3, U4, U5, U6, U8, U9);
            Game1.collisionExecute(U7, U2, U1, U0, U3, U4, U5, U6, U8, U9);
            Game1.collisionExecute(U7, U3, U1, U2, U0, U4, U5, U6, U8, U9);
            Game1.collisionExecute(U7, U4, U1, U2, U3, U0, U5, U6, U8, U9);
            Game1.collisionExecute(U7, U5, U1, U2, U3, U4, U0, U6, U8, U9);
            Game1.collisionExecute(U7, U6, U1, U2, U3, U4, U5, U0, U8, U9);
            Game1.collisionExecute(U7, U8, U1, U2, U3, U4, U5, U6, U0, U9);
            Game1.collisionExecute(U7, U9, U1, U2, U3, U4, U5, U6, U8, U0);

            //Unit 9
            Game1.collisionExecute(U8, U0, U1, U2, U3, U4, U5, U6, U7, U9);
            Game1.collisionExecute(U8, U1, U0, U2, U3, U4, U5, U6, U7, U9);
            Game1.collisionExecute(U8, U2, U1, U0, U3, U4, U5, U6, U7, U9);
            Game1.collisionExecute(U8, U3, U1, U2, U0, U4, U5, U6, U7, U9);
            Game1.collisionExecute(U8, U4, U1, U2, U3, U0, U5, U6, U7, U9);
            Game1.collisionExecute(U8, U5, U1, U2, U3, U4, U0, U6, U7, U9);
            Game1.collisionExecute(U8, U6, U1, U2, U3, U4, U5, U0, U7, U9);
            Game1.collisionExecute(U8, U7, U1, U2, U3, U4, U5, U6, U0, U9);
            Game1.collisionExecute(U8, U9, U1, U2, U3, U4, U5, U6, U7, U0);

            //Unit 10
            Game1.collisionExecute(U9, U0, U1, U2, U3, U4, U5, U6, U7, U8);
            Game1.collisionExecute(U9, U1, U0, U2, U3, U4, U5, U6, U7, U8);
            Game1.collisionExecute(U9, U2, U1, U0, U3, U4, U5, U6, U7, U8);
            Game1.collisionExecute(U9, U3, U1, U2, U0, U4, U5, U6, U7, U8);
            Game1.collisionExecute(U9, U4, U1, U2, U3, U0, U5, U6, U7, U8);
            Game1.collisionExecute(U9, U5, U1, U2, U3, U4, U0, U6, U7, U8);
            Game1.collisionExecute(U9, U6, U1, U2, U3, U4, U5, U0, U7, U8);
            Game1.collisionExecute(U9, U7, U1, U2, U3, U4, U5, U6, U0, U8);
            Game1.collisionExecute(U9, U8, U1, U2, U3, U4, U5, U6, U7, U0);

            //Label1 = Funds label
            Game1.setTotalMoney(Game1.getTotalMoney() + 12);
            label1.Text = "Funds: " + Game1.getTotalMoney().ToString();

            label2.Text = "Base Health: " + Game1.getbaseHealth();
            label3.Text = "Enemy Base Health: " + Game1.getEnemybaseHealth();

            if (Game1.getbaseHealth() <= 0)
            {
                WinLoose.Visible = true;
                WinLoose.Text = "YOU LOOSE";
                endGame();
                //lose
            }

            if (Game1.getEnemybaseHealth() <= 0)
            {
                WinLoose.Visible = true;
                WinLoose.Text = "YOU WIN";
                endGame();
                //win                
            }

            spawnEnemy = spawnEnemy + 1;

            if (spawnEnemy > 200)
            {
                spawnUnitDefinition((rnd.Next(1, 4)) * 2);
                
                spawnEnemy = 0;
            }

            if (Game1.getTotalMoney() < 1500)
            {
                SpawnFreindlyHumvee.BackColor = Color.DarkGray;
                SpawnRocketTruck.BackColor = Color.DarkGray;
                SpawnTank.BackColor = Color.DarkGray;
                SpawnGunCar.BackColor = Color.DarkGray;

            }
            else if (Game1.getTotalMoney() < 2500)
            {
                SpawnRocketTruck.BackColor = Color.DarkGray;
                SpawnTank.BackColor = Color.DarkGray;
                SpawnGunCar.BackColor = Color.DarkGray;

                SpawnFreindlyHumvee.BackColor = Color.LightGray;
            }
            else if (Game1.getTotalMoney() < 5000)
            {
                
                SpawnTank.BackColor = Color.DarkGray;

                SpawnGunCar.BackColor = Color.LightGray;
                SpawnRocketTruck.BackColor = Color.LightGray;
                SpawnFreindlyHumvee.BackColor = Color.LightGray;
            }
            else
            {
                SpawnTank.BackColor = Color.LightGray;
                SpawnGunCar.BackColor = Color.LightGray;
                SpawnRocketTruck.BackColor = Color.LightGray;
                SpawnFreindlyHumvee.BackColor = Color.LightGray;
            }


        }

        //ignore
        public void lanscapeBounds_Paint(object sender, PaintEventArgs e)
        {
            //ignore
        }

        
        
        //Code ran when Move Unit is clicked
        private void moveUnit_Click(object sender, EventArgs e)
        {
            //code ran within the unit class to set its movement statis to true if the unit is spawned
            
        }

        //Code ran when Stop Unit is clicked
        private void stopUnit_Click(object sender, EventArgs e)
        {
            //code ran within the unit class to set its movement statis to false
           
           
        }


        //Code ran when Spawn Tank is clicked
        private void spawnUnitButton_Click(object sender, EventArgs e)
        {
            if (Game1.getTotalMoney() >= 5000)
            { 
                spawnUnitDefinition(1);
                SpawnTank.BackColor = Color.DarkGreen;
            }
            else
            {
                SpawnTank.BackColor = Color.Red;
            }
        }

        private void SpawnEnemyTank_Click_1(object sender, EventArgs e)
        {
            spawnUnitDefinition(2);
        }

        //Code Ran when Spawn gun car is clicked
        private void spawnEnemyTank_Click(object sender, EventArgs e)
        {
            if (Game1.getTotalMoney() >= 2500)
            {
                spawnUnitDefinition(3);
                SpawnGunCar.BackColor = Color.DarkGreen;
            }
            else
            {
                SpawnGunCar.BackColor = Color.Red;
            }

        }

        private void SpawnEnemyGunCar_Click(object sender, EventArgs e)
        {

            spawnUnitDefinition(4);
        }
        private void SpawnRocketTruck_Click(object sender, EventArgs e)
        {
            if (Game1.getTotalMoney() >= 2500)
            { 
                spawnUnitDefinition(5);
                SpawnRocketTruck.BackColor = Color.DarkGreen;
            }
            else
            {
                SpawnRocketTruck.BackColor = Color.Red;
            }

        }
        private void SpawnEnemyRocketTruck_Click(object sender, EventArgs e)
        {
            spawnUnitDefinition(6);
        }
        private void SpawnFreindlyHumvee_Click(object sender, EventArgs e)
        {
            if (Game1.getTotalMoney() >= 1500)
            { 
                spawnUnitDefinition(7);
                SpawnFreindlyHumvee.BackColor = Color.DarkGreen;
            }
            else
            {
                SpawnFreindlyHumvee.BackColor = Color.Red;
            }
        }

        //Spawn enemy humvee
        private void button1_Click_1(object sender, EventArgs e)
        {
            spawnUnitDefinition(8);
        }

        private void spawnUnitDefinition(int unitNumber)
        {

            currentUnitNumber = Game1.nextAvaliableUnit();
            if (currentUnitNumber == -1 | Game1.getUnitState(currentUnitNumber) == true)
            {
                //Max num of units spawned
            }
            else
            {
                //Needs to be changed into procedure in game model class (Iteration 2)
                Game1.setUnitState(true, currentUnitNumber);
                switch (currentUnitNumber)
                {
                    case 0:
                        U0.unitDefinition(unitNumber);
                        U0.spawnUnit(Curve1.getPoints(), this, Game1);
                        U0.setUnitArrayPosition(currentUnitNumber);
                        Game1.setNewUnitLocation(currentUnitNumber, U0.getUnitLocation());
                        this.Refresh();
                        break;
                    case 1:
                        U1.unitDefinition(unitNumber);
                        U1.spawnUnit(Curve1.getPoints(), this, Game1);
                        U1.setUnitArrayPosition(currentUnitNumber);
                        Game1.setNewUnitLocation(currentUnitNumber, U1.getUnitLocation());
                        this.Refresh();
                        break;
                    case 2:
                        U2.unitDefinition(unitNumber);
                        U2.spawnUnit(Curve1.getPoints(), this, Game1);
                        U2.setUnitArrayPosition(currentUnitNumber);
                        Game1.setNewUnitLocation(currentUnitNumber, U2.getUnitLocation());
                        this.Refresh();
                        break;
                    case 3:
                        U3.unitDefinition(unitNumber);
                        U3.spawnUnit(Curve1.getPoints(), this, Game1);
                        U3.setUnitArrayPosition(currentUnitNumber);
                        Game1.setNewUnitLocation(currentUnitNumber, U3.getUnitLocation());
                        this.Refresh();
                        break;
                    case 4:
                        U4.unitDefinition(unitNumber);
                        U4.spawnUnit(Curve1.getPoints(), this, Game1);
                        U4.setUnitArrayPosition(currentUnitNumber);
                        Game1.setNewUnitLocation(currentUnitNumber, U4.getUnitLocation());
                        this.Refresh();
                        break;
                    case 5:
                        U5.unitDefinition(unitNumber);
                        U5.spawnUnit(Curve1.getPoints(), this, Game1);
                        U5.setUnitArrayPosition(currentUnitNumber);
                        Game1.setNewUnitLocation(currentUnitNumber, U5.getUnitLocation());
                        this.Refresh();
                        break;
                    case 6:
                        U6.unitDefinition(unitNumber);
                        U6.spawnUnit(Curve1.getPoints(), this, Game1);
                        U6.setUnitArrayPosition(currentUnitNumber);
                        Game1.setNewUnitLocation(currentUnitNumber, U6.getUnitLocation());
                        this.Refresh();
                        break;
                    case 7:
                        U7.unitDefinition(unitNumber);
                        U7.spawnUnit(Curve1.getPoints(), this, Game1);
                        U7.setUnitArrayPosition(currentUnitNumber);
                        Game1.setNewUnitLocation(currentUnitNumber, U7.getUnitLocation());
                        this.Refresh();
                        break;
                    case 8:
                        U8.unitDefinition(unitNumber);
                        U8.spawnUnit(Curve1.getPoints(), this, Game1);
                        U8.setUnitArrayPosition(currentUnitNumber);
                        Game1.setNewUnitLocation(currentUnitNumber, U8.getUnitLocation());
                        this.Refresh();
                        break;
                    case 9:
                        U9.unitDefinition(unitNumber);
                        U9.spawnUnit(Curve1.getPoints(), this, Game1);
                        U9.setUnitArrayPosition(currentUnitNumber);
                        Game1.setNewUnitLocation(currentUnitNumber, U9.getUnitLocation());
                        this.Refresh();
                        break;
                }
                Game1.setUnitNumber(Game1.getUnitNumber() + 1);
            }

        }

       private void endGame()
        {
            timer1.Stop();
        }

        private void label1_Click(object sender, EventArgs e)
        {
            //Ignore
        }

        private void Background_Paint(object sender, PaintEventArgs e)
        {
            //ignore
        }


        //Pause Button
        private void button1_Click_2(object sender, EventArgs e)
        {
            timer1.Stop();

            label6.Text = "Objective: Use funds to purchase units under your command to counter enemy forces.\n\nDestroy the enemy base by sending units to the far end of the landscape, this will\ndecrease the enemy base health. Once it reaches 0, the mission is sucsessful.\n\nDo not allow enemy units to reach your base this will result in the end of the mission if\nyour base health becomes 0.";
           label7.Visible = true;
            label8.Visible = true;
            Play.Visible = true;
            label9.Visible = true;
        }
   
        private void label5_Click(object sender, EventArgs e)
        {
            //ignore
        }

        private void Play_Click(object sender, EventArgs e)
        {
            timer1.Start();

            label6.Text = "";
            label7.Visible = false;
            label8.Visible = false;
            Play.Visible = false;
            label9.Visible = false;
        }

        private void TankHover_Click(object sender, EventArgs e)
        {
            label6.Text = "The Tank\n\nThe Tank is the most valued military vehicle.\nIt has the most health for any unit, and a strong attack.\n\nHowever, thier price can have an impact on their situational effectivness.";
        }

        private void GunCarHover_Click(object sender, EventArgs e)
        {
            label6.Text = "The GunCar\n\nThe GunCar is a strategic vehicle which can engage enemies at long distances.\nThese units are deadly in numbers, as they can take down enemies before they are even in range of attack.\n\nThese units have very little health.";
        }
       

        private void RocketTruckHover_Click(object sender, EventArgs e)
        {
            label6.Text = "The Rocket Truck\n\nDue to the Tank dominance on the battle feild, the Rocket Truck was developed.\nRocket Trucks can eliminate a Tank although they are cheaper to manurfacture.\n\nThey have extreamly high attack capabilities but are fragile.";
        }

        private void HumveeHover_Click(object sender, EventArgs e)
        {
            label6.Text = "The Humvee\n\nThe most abundent military unit due to its ease of mobilization.\nDecent attack and range, used best in numbers against weaker opponents.";
        }



        //ignore
        private void Form1_Load(object sender, EventArgs e)
        {
            label6.Text = "";
        }
         //ignore
        private void WinLoose_Click(object sender, EventArgs e)
        {

        }
    }
}
