using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Drawing;
using System.Windows.Forms;


namespace Prototype1
{
    public class Unit
    {

        //Attributes of Units
        bool movementValid = false;

        int unitLeftValue = 0;
        int unitUpValue = 0;
        double gradient = 0;
        bool spawned = false;

        int Ydifference = 0;
        int Xdifference = 0;
        double gradientAdd = 0;
        double leftAdd = 0;

        int arrayPosition = 0;




        //Values to be passed in depending on the unit type
        int unitType = 0;
        int unitHight = 0;
        int unitWidth = 0;
        double unitSpeed = 0;
        int unitRange = 0;
        int unitHealth = 0;
        int unitAttack = 0;
        bool unitAlive = false;
        //Creates instance of a picture box for the unit to be visualized
        PictureBox Unit1 = new PictureBox();

        //Creates istance of type of unit depending on passed through unit type

        public void unitDefinition(int unitTypeInput)
        {

            switch (unitTypeInput)
            {
                case 0: //Testing purposes only
                    UnitTestClass testUnit = new UnitTestClass();
                    unitHight = testUnit.getUnitHight();
                    unitWidth = testUnit.getUnitWidth();
                    unitSpeed = testUnit.getUnitSpeed();
                    unitRange = testUnit.getUnitRange();
                    unitHealth = testUnit.getUnitHealth();
                    unitAttack = testUnit.getUnitAttack();


                    break;

                case 1: //Freindly Tank

                    //Create an instance of Freindly tank
                    FreindlyTank FT = new FreindlyTank();
                    unitHight = FT.getUnitHight();
                    unitWidth = FT.getUnitWidth();
                    unitSpeed = FT.getUnitSpeed();
                    unitRange = FT.getUnitRange();
                    unitHealth = FT.getUnitHealth();
                    unitAttack = FT.getUnitAttack();
                    Unit1.Image = Properties.Resources.FreindlyTankImage;

                    break;

                case 2:

                    //Create an instance of Enemy tank
                    EnemyTank ET = new EnemyTank();
                    unitHight = ET.getUnitHight();
                    unitWidth = ET.getUnitWidth();
                    unitSpeed = ET.getUnitSpeed();
                    unitRange = ET.getUnitRange();
                    unitHealth = ET.getUnitHealth();
                    unitAttack = ET.getUnitAttack();
                    Unit1.Image = Properties.Resources.EnemyTankImage;

                    break;

            }
            unitType = unitTypeInput;
        }





        //Function calculating the new location of the unit using its current
        //X and Y values (unitLeftValue and unitUpValue) and the points the 
        //landscape is passing through
        public Point newUnitLocation(Point[] curvePoints)
        {
            //Checks if the movement is actually supposed to be made
            if (movementValid == true)
            {
                if (unitSpeed > 0)
                {

                    //Here the program calculates the gradient of the line the 
                    //Unit is currently on, using the points its between
                    if (unitLeftValue < curvePoints[1].X - (unitWidth / 2))
                    {
                        Ydifference = curvePoints[0].Y - curvePoints[1].Y;
                        Xdifference = curvePoints[0].X - curvePoints[1].X;

                    }
                    else if (unitLeftValue < curvePoints[2].X - (unitWidth / 2))
                    {
                        Ydifference = curvePoints[1].Y - curvePoints[2].Y;
                        Xdifference = curvePoints[1].X - curvePoints[2].X;

                    }
                    else if (unitLeftValue < curvePoints[3].X - (unitWidth / 2))
                    {
                        Ydifference = curvePoints[2].Y - curvePoints[3].Y;
                        Xdifference = curvePoints[2].X - curvePoints[3].X;

                    }
                    else if (unitLeftValue < curvePoints[4].X - (unitWidth / 2))
                    {
                        Ydifference = curvePoints[3].Y - curvePoints[4].Y;
                        Xdifference = curvePoints[3].X - curvePoints[4].X;

                    }
                    else if (unitLeftValue < curvePoints[5].X - (unitWidth / 2))
                    {
                        Ydifference = curvePoints[4].Y - curvePoints[5].Y;
                        Xdifference = curvePoints[4].X - curvePoints[5].X;

                    }
                    else if (unitLeftValue < curvePoints[6].X - (unitWidth / 2))
                    {
                        Ydifference = curvePoints[5].Y - curvePoints[6].Y;
                        Xdifference = curvePoints[5].X - curvePoints[6].X;

                    }
                    else
                    {
                        Ydifference = 0;
                        Xdifference = 0;
                    }

                    //Gradient calculation here, using (double) for a none rounded result.
                    gradient = (double)Ydifference / Xdifference;
                    gradientAdd = gradientAdd + (double)(gradient * unitSpeed);
                    leftAdd = leftAdd + (1 * unitSpeed);

                    //gradient add is used due to the limmitations of moving a unit up
                    //only pixle by pixle, so the unit is only moved when its total Y
                    //movement is greater than 1 pixle.
                    while (gradientAdd >= 1)
                    {
                        unitUpValue = unitUpValue + (int)gradientAdd;
                        gradientAdd = gradientAdd - 1;
                    }
                    while (gradientAdd <= -1)
                    {
                        unitUpValue = unitUpValue + (int)gradientAdd;
                        gradientAdd = gradientAdd + 1;
                    }

                    //Now that the speed multiplier is creted, left add is used due to
                    //the limmitations of moving a unit up
                    //only pixle by pixle, so the unit is only moved when its total Y
                    //movement is greater than 1 pixle.
                    while (leftAdd >= 1)
                    {
                        unitLeftValue = unitLeftValue + (int)leftAdd;
                        leftAdd = leftAdd - (int)leftAdd;
                    }
                    while (leftAdd <= -1)
                    {
                        unitLeftValue = unitLeftValue + (int)leftAdd;
                        leftAdd = leftAdd + (int)leftAdd;
                    }

                    //New point which is returned is created here.
                    Point newPoint = new Point(unitLeftValue, unitUpValue);
                    return newPoint;
                }
                else
                {

                    //Here the program calculates the gradient of the line the 
                    //Unit is currently on, using the points its between
                    if (unitLeftValue > curvePoints[5].X - (unitWidth / 2))
                    {
                        Ydifference = curvePoints[6].Y - curvePoints[5].Y;
                        Xdifference = curvePoints[6].X - curvePoints[5].X;

                    }
                    else if (unitLeftValue > curvePoints[4].X - (unitWidth / 2))
                    {
                        Ydifference = curvePoints[5].Y - curvePoints[4].Y;
                        Xdifference = curvePoints[5].X - curvePoints[4].X;

                    }
                    else if (unitLeftValue > curvePoints[3].X - (unitWidth / 2))
                    {
                        Ydifference = curvePoints[4].Y - curvePoints[3].Y;
                        Xdifference = curvePoints[4].X - curvePoints[3].X;

                    }
                    else if (unitLeftValue > curvePoints[2].X - (unitWidth / 2))
                    {
                        Ydifference = curvePoints[3].Y - curvePoints[2].Y;
                        Xdifference = curvePoints[3].X - curvePoints[2].X;

                    }
                    else if (unitLeftValue > curvePoints[1].X - (unitWidth / 2))
                    {
                        Ydifference = curvePoints[2].Y - curvePoints[1].Y;
                        Xdifference = curvePoints[2].X - curvePoints[1].X;

                    }
                    else if (unitLeftValue > curvePoints[0].X - (unitWidth / 2))
                    {
                        Ydifference = curvePoints[1].Y - curvePoints[0].Y;
                        Xdifference = curvePoints[1].X - curvePoints[0].X;

                    }
                    else
                    {
                        Ydifference = 0;
                        Xdifference = 0;
                    }

                    //Gradient calculation here, using (double) for a none rounded result.
                    gradient = (double)Ydifference / Xdifference;
                    gradientAdd = gradientAdd + (double)(gradient * unitSpeed);
                    leftAdd = leftAdd + (1 * unitSpeed);

                    //gradient add is used due to the limmitations of moving a unit up
                    //only pixle by pixle, so the unit is only moved when its total Y
                    //movement is greater than 1 pixle.
                    while (gradientAdd >= 1)
                    {
                        unitUpValue = unitUpValue + (int)gradientAdd;
                        gradientAdd = gradientAdd - 1;
                    }
                    while (gradientAdd <= -1)
                    {
                        unitUpValue = unitUpValue + (int)gradientAdd;
                        gradientAdd = gradientAdd + 1;
                    }

                    //Now that the speed multiplier is creted, left add is used due to
                    //the limmitations of moving a unit up
                    //only pixle by pixle, so the unit is only moved when its total Y
                    //movement is greater than 1 pixle.

                    while (leftAdd >= 1)
                    {
                        unitLeftValue = unitLeftValue + (int)leftAdd;
                        leftAdd = leftAdd - (int)leftAdd;
                    }

                    while (leftAdd <= -1)
                    {
                        unitLeftValue = unitLeftValue + (int)leftAdd;
                        leftAdd = leftAdd - (int)leftAdd;
                    }

                    //New point which is returned is created here.
                    Point newPoint = new Point(unitLeftValue, unitUpValue);
                    return newPoint;



                }

            }
            //Fail
            Point newPointF = new Point(0, 0);
            return newPointF;
        }



        //Procedure which spawns the unit onto the form at the start point
        //of the landscape, taking in the form and curvepoints as a parameter.
        public void spawnUnit(Point[] curvePoints, Form1 screen)
        {

            unitAlive = true;

            if (unitSpeed > 0)
            {
                //Freindly unit because of positive speed


                //Calculate start point of unit
                int offset = curvePoints[0].Y - unitHight;
                Point point1 = new Point(curvePoints[0].X, offset);

                //Set unit image and location

                Unit1.Location = point1;
                //setUnitUp(point1.Y);
                Unit1.Visible = true;


                //Set pitcure box the right width and background
                Unit1.BackColor = Color.Transparent;
                Unit1.Width = unitWidth;
                Unit1.Height = unitHight;

                //Add the picturebox and refresh the screen of the form.
                screen.Controls.Add(Unit1);
                screen.lanscapeBounds.SendToBack();
                screen.Refresh();

                //set spawned state to true so the move unit function is called
                spawned = true;
                unitLeftValue = point1.X;
                unitUpValue = point1.Y;



            }

            if (unitSpeed < 0)
            {

                //Enemy Unit because of negitive speed


                //Calculate start point of unit
                int offset = curvePoints[curvePoints.Length - 1].Y - unitHight;
                Point point1 = new Point(curvePoints[curvePoints.Length - 1].X - unitWidth, offset);

                //Set unit image and location

                Unit1.Location = point1;
                //setUnitUp(point1.Y);
                Unit1.Visible = true;


                //Set pitcure box the right width and background
                Unit1.BackColor = Color.Transparent;
                Unit1.Width = unitWidth; 
                Unit1.Height = unitHight;

                //Add the picturebox and refresh the screen of the form.
                screen.Controls.Add(Unit1);
                screen.lanscapeBounds.SendToBack();
                screen.Refresh();

                //set spawned state to true so the move unit function is called
                spawned = true;
                unitLeftValue = point1.X;
                unitUpValue = point1.Y;


            }
        }

        //Function which actually moves the unit on the form
        //taking in the curve points and form as parameters.
        public void moveUnit(Point[] curvePoints, Form1 screen)
        {
            //Calls newUnitLocation procedure 
            Unit1.Location = newUnitLocation(curvePoints);

            //Make sure th unit picturebox is vivible infront of the landscape panel.
            screen.lanscapeBounds.SendToBack();

            //Refresh screen so new location of picturebox is implemented.
            screen.Refresh();





        }

        public bool takeDamage(int damage, GameModel Game1)
        {
            unitHealth = unitHealth - damage;
            if (unitHealth < 0)
            {
                //Death
                unitDeath(Game1);
                return true;

            }
            return false;
        }

        public void unitDeath(GameModel Game1)
        {
            Unit1.Visible = false;
            unitUpValue = 0;
            unitLeftValue = 0;
            movementValid = false;
            unitAlive = false;
            Game1.setUnitState(false, getUnitArrayPosition());
            gradient = 0;
            spawned = false;
            gradientAdd = 0;
            leftAdd = 0;

            Game1.setUnitNumber(Game1.getUnitNumber() - 1); //Write2word

        }

        //Set and Get public funtions and procedures
        public bool getvalid()
        {
            return movementValid;
        }

        public void setValid(bool valid)
        {
            movementValid = valid;
        }

        public int getHight()
        {
            return unitHight;
        }

        public int getWidth()
        {
            return unitWidth;
        }

        public double getSpeed()
        {
            return unitSpeed;
        }

        public bool getUnitSpawn()
        {
            return spawned;
        }

        
        //
        public void setUnitUp(int up)
        {
            unitUpValue = up;
        }

        public void setUnitArrayPosition(int newPosition)
        {
            arrayPosition = newPosition;
        }

        public int getUnitArrayPosition()
        {
            return arrayPosition;
        }

        public Point getUnitLocation()
        {
            Point location = new Point(unitLeftValue, unitUpValue);
            return location;
        }
        public int getUnitRange()
        {
            return unitRange;
        }
        
        public int getUnitAttack()
        {
            return unitAttack;
        }

        public bool getunitAlive()
        {
            return unitAlive;
        }
        public void setUnitAlive(bool alive)
        {
            unitAlive = alive;
        }


        //For testing purposes:
        public void setUnitLeftValue(int value)
        {
            unitLeftValue = value;
        }
        public void setUnitUpValue(int value)
        {
            unitUpValue = value;
        }
        public void setUnitSpawnValue(bool state)
        {
            spawned = state;
        }
       

    }
}
