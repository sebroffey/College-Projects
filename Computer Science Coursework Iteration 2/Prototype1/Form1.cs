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

        
        //...................................................................................................................
        //Iteration 2)
        //Transfer relevent code across to more appropriate location in 'game model'
        //This will create code easier to navigate and understand due to current mixed code function locations.
        //...................................................................................................................
        
            
            
            
            
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


        //Landscape Button Click
        private void button1_Click(object sender, EventArgs e)
        {

            //Causes all dictated paint values to be called
            plot = true;
            Curve1.generateRandom();

            //reset all units by calling unit death on all unit instances.
            U0.unitDeath(Game1);
            U1.unitDeath(Game1);
            U2.unitDeath(Game1);
            U3.unitDeath(Game1);
            U4.unitDeath(Game1);
            U5.unitDeath(Game1);
            U6.unitDeath(Game1);
            U7.unitDeath(Game1);
            U8.unitDeath(Game1);
            U9.unitDeath(Game1);

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
        }

























        //ignore
        public void lanscapeBounds_Paint(object sender, PaintEventArgs e)
        {
            //ignore
        }

        //Code ran when Spawn Unit is clicked
        private void spawnUnitButton_Click(object sender, EventArgs e)
        {

            currentUnitNumber = Game1.nextAvaliableUnit();
            if (currentUnitNumber == -1 | Game1.getUnitState(currentUnitNumber) == true)
            {
                //Max num of units spawned
            }

            else
            {
                //change array state of given unit in game model
                Game1.setUnitState(true, currentUnitNumber);

                //Switch hard coded calling of methods for each instance of unit called.
                //
                //
                //Going to create procedure 'Spawn unit' in game model to remove code from form and also reduce repeated 
                //code observed in spawnEnemyTank_Click() in Iteration 2.
                //
                //
                //
                switch (currentUnitNumber)

                {
                    case 0:
                        U0.unitDefinition(1);
                        U0.spawnUnit(Curve1.getPoints(), this);
                        U0.setUnitArrayPosition(currentUnitNumber);
                        Game1.setNewUnitLocation(currentUnitNumber, U0.getUnitLocation());
                        this.Refresh();
                        break;
                    case 1:
                        U1.unitDefinition(1);
                        U1.spawnUnit(Curve1.getPoints(), this);
                        U1.setUnitArrayPosition(currentUnitNumber);
                        Game1.setNewUnitLocation(currentUnitNumber, U1.getUnitLocation());
                        this.Refresh();
                        break;
                    case 2:
                        U2.unitDefinition(1);
                        U2.spawnUnit(Curve1.getPoints(), this);
                        U2.setUnitArrayPosition(currentUnitNumber);
                        Game1.setNewUnitLocation(currentUnitNumber, U2.getUnitLocation());
                        this.Refresh();
                        break;
                    case 3:
                        U3.unitDefinition(1);
                        U3.spawnUnit(Curve1.getPoints(), this);
                        U3.setUnitArrayPosition(currentUnitNumber);
                        Game1.setNewUnitLocation(currentUnitNumber, U3.getUnitLocation());
                        this.Refresh();
                        break;
                    case 4:
                        U4.unitDefinition(1);
                        U4.spawnUnit(Curve1.getPoints(), this);
                        U4.setUnitArrayPosition(currentUnitNumber);
                        Game1.setNewUnitLocation(currentUnitNumber, U4.getUnitLocation());
                        this.Refresh();
                        break;
                    case 5:
                        U5.unitDefinition(1);
                        U5.spawnUnit(Curve1.getPoints(), this);
                        U5.setUnitArrayPosition(currentUnitNumber);
                        Game1.setNewUnitLocation(currentUnitNumber, U5.getUnitLocation());
                        this.Refresh();
                        break;
                    case 6:
                        U6.unitDefinition(1);
                        U6.spawnUnit(Curve1.getPoints(), this);
                        U6.setUnitArrayPosition(currentUnitNumber);
                        Game1.setNewUnitLocation(currentUnitNumber, U6.getUnitLocation());
                        this.Refresh();
                        break;
                    case 7:
                        U7.unitDefinition(1);
                        U7.spawnUnit(Curve1.getPoints(), this);
                        U7.setUnitArrayPosition(currentUnitNumber);
                        Game1.setNewUnitLocation(currentUnitNumber, U7.getUnitLocation());
                        this.Refresh();
                        break;
                    case 8:
                        U8.unitDefinition(1);
                        U8.spawnUnit(Curve1.getPoints(), this);
                        U8.setUnitArrayPosition(currentUnitNumber);
                        Game1.setNewUnitLocation(currentUnitNumber, U8.getUnitLocation());
                        this.Refresh();
                        break;
                    case 9:
                        U9.unitDefinition(1);
                        U9.spawnUnit(Curve1.getPoints(), this);
                        U9.setUnitArrayPosition(currentUnitNumber);
                        Game1.setNewUnitLocation(currentUnitNumber, U9.getUnitLocation());
                        this.Refresh();
                        break;

                }

                Game1.setUnitNumber(Game1.getUnitNumber() + 1);
            }
            

            

            
            
            
            
           
        }
        
        //Code ran when Spawn Unit is clicked
        private void moveUnit_Click(object sender, EventArgs e)
        {
            //code ran within the unit class to set its movement statis to true if the unit is spawned
            if (U0.getUnitSpawn() == true)
            {
                U0.setValid(true);
            }
            if (U1.getUnitSpawn() == true)
            {
                U1.setValid(true);
            }
            if (U2.getUnitSpawn() == true)
            {
                U2.setValid(true);
            }
            if (U3.getUnitSpawn() == true)
            {
                U3.setValid(true);
            }
            if (U4.getUnitSpawn() == true)
            {
                U4.setValid(true);
            }
            if (U5.getUnitSpawn() == true)
            {
                U5.setValid(true);
            }
            if (U6.getUnitSpawn() == true)
            {
                U6.setValid(true);
            }
            if (U7.getUnitSpawn() == true)
            {
                U7.setValid(true);
            }
            if (U8.getUnitSpawn() == true)
            {
                U8.setValid(true);
            }
            if (U9.getUnitSpawn() == true)
            {
                U9.setValid(true);
            }

        }

        //Code ran when Spawn Unit is clicked
        private void stopUnit_Click(object sender, EventArgs e)
        {
            //code ran within the unit class to set its movement statis to false
            U0.setValid(false);
            U1.setValid(false);
            U2.setValid(false);
            U3.setValid(false);
            U4.setValid(false);
            U5.setValid(false);
            U6.setValid(false);
            U7.setValid(false);
            U8.setValid(false);
            U9.setValid(false);
            U0.setValid(false);

            



        }

        private void spawnEnemyTank_Click(object sender, EventArgs e)
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
                        U0.unitDefinition(2);
                        U0.spawnUnit(Curve1.getPoints(), this);
                        U0.setUnitArrayPosition(currentUnitNumber);
                        Game1.setNewUnitLocation(currentUnitNumber, U0.getUnitLocation());
                        this.Refresh();
                        break;
                    case 1:
                        U1.unitDefinition(2);
                        U1.spawnUnit(Curve1.getPoints(), this);
                        U1.setUnitArrayPosition(currentUnitNumber);
                        Game1.setNewUnitLocation(currentUnitNumber, U1.getUnitLocation());
                        this.Refresh();
                        break;
                    case 2:
                        U2.unitDefinition(2);
                        U2.spawnUnit(Curve1.getPoints(), this);
                        U2.setUnitArrayPosition(currentUnitNumber);
                        Game1.setNewUnitLocation(currentUnitNumber, U2.getUnitLocation());
                        this.Refresh();
                        break;
                    case 3:
                        U3.unitDefinition(2);
                        U3.spawnUnit(Curve1.getPoints(), this);
                        U3.setUnitArrayPosition(currentUnitNumber);
                        Game1.setNewUnitLocation(currentUnitNumber, U3.getUnitLocation());
                        this.Refresh();
                        break;
                    case 4:
                        U4.unitDefinition(2);
                        U4.spawnUnit(Curve1.getPoints(), this);
                        U4.setUnitArrayPosition(currentUnitNumber);
                        Game1.setNewUnitLocation(currentUnitNumber, U4.getUnitLocation());
                        this.Refresh();
                        break;
                    case 5:
                        U5.unitDefinition(2);
                        U5.spawnUnit(Curve1.getPoints(), this);
                        U5.setUnitArrayPosition(currentUnitNumber);
                        Game1.setNewUnitLocation(currentUnitNumber, U5.getUnitLocation());
                        this.Refresh();
                        break;
                    case 6:
                        U6.unitDefinition(2);
                        U6.spawnUnit(Curve1.getPoints(), this);
                        U6.setUnitArrayPosition(currentUnitNumber);
                        Game1.setNewUnitLocation(currentUnitNumber, U6.getUnitLocation());
                        this.Refresh();
                        break;
                    case 7:
                        U7.unitDefinition(2);
                        U7.spawnUnit(Curve1.getPoints(), this);
                        U7.setUnitArrayPosition(currentUnitNumber);
                        Game1.setNewUnitLocation(currentUnitNumber, U7.getUnitLocation());
                        this.Refresh();
                        break;
                    case 8:
                        U8.unitDefinition(2);
                        U8.spawnUnit(Curve1.getPoints(), this);
                        U8.setUnitArrayPosition(currentUnitNumber);
                        Game1.setNewUnitLocation(currentUnitNumber, U8.getUnitLocation());
                        this.Refresh();
                        break;
                    case 9:
                        U9.unitDefinition(2);
                        U9.spawnUnit(Curve1.getPoints(), this);
                        U9.setUnitArrayPosition(currentUnitNumber);
                        Game1.setNewUnitLocation(currentUnitNumber, U9.getUnitLocation());
                        this.Refresh();
                        break;

                }

                Game1.setUnitNumber(Game1.getUnitNumber() + 1);

            }

            

            

        }
    }
    

}
