using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Drawing;

namespace Prototype1
{   
    
    //Control of program mechanics

    public class GameModel
    {
        
        //Declaring vriables
        int unitNumber = 0;
        private Point[] unitLocations;
        int[] arrayOfDistances = new int[] { 0, 0, 0, 0, 0, 0, 0, 0, 0 };

        bool[] unitStates = new bool[] { false, false, false, false, false, false, false, false, false, false };

        int totalMoney = 0;
        int baseHealth = 100;
        int enemyBaseHealth = 100;

        

        //Constructor defining point instances and array of unitLocations.
        public GameModel()
        {
            Point point1 = new Point(0, 0);
            Point point2 = new Point(0, 0);
            Point point3 = new Point(0, 0);
            Point point4 = new Point(0, 0);
            Point point5 = new Point(0, 0);
            Point point6 = new Point(0, 0);
            Point point7 = new Point(0, 0);
            Point point8 = new Point(0, 0);
            Point point9 = new Point(0, 0);
            Point point10 = new Point(0, 0);

            unitLocations = new Point[] { point1, point2, point3, point4, point5, point6, point7, point8, point9, point10 };
        }


        //Private function referenced only in the class.
        private int[] collisionDetect(int unitNum)
        {


            //Finding range between all unit locations in the unitLocations array
            //and the unit location element index passed in as parameter.
            int difference = 0;
            int[] collisionRanges;
            collisionRanges = new int[] { 0, 0, 0, 0, 0, 0, 0, 0, 0, 0 };
            Point empty = new Point(0, 0);

            //for loop allows for comparison of all elements in the array.
            for (int index = 0; index < unitLocations.Length; index++)
            {
                if (unitLocations[index] != empty)
                {
                    difference = unitLocations[unitNum].X - unitLocations[index].X;
                    collisionRanges[index] = difference;
                }
            }

            //Returned array containing distances corrispondng to the
            //unit location elements position in the array.
            return collisionRanges ;
        }


        //Unit instances passed in as parameters
        //controls unit actions based upon calculated circumstances
        public void collisionExecute(Unit attacker, Unit victim, Unit T0, Unit T1, Unit T2, Unit T3, Unit T4, Unit T5, Unit T6, Unit T7)
        {
            arrayOfDistances = collisionDetect(attacker.getUnitArrayPosition());

            //defult dead unit location
            Point nul = new Point(0, 0);

            if (attacker.getunitAlive() == true)
            {
                //Different speds require different code as units should attack eachother if they are on the same side.
                //the unit
                if (attacker.getSpeed() < 0)
                {
                    //conditions for an attack to occur
                    if (arrayOfDistances[victim.getUnitArrayPosition()] < attacker.getUnitRange() && victim.getUnitLocation() != nul && victim.getSpeed() > 0)
                    {
                        //attacker stops moving whilst attack occurs.
                        attacker.setValid(false);
                        
                        if (victim.takeDamage(attacker.getUnitAttack(),this) == true)
                        {
                            //attacker needs to be able to contine moving acros landscape
                            attacker.setValid(true);

                            //If attacked unit is on the same team
                            if (T0.getSpeed() < 0)
                            {
                                T0.setValid(true);
                            }
                            if (T1.getSpeed() < 0)
                            {
                                T1.setValid(true);
                            }
                            if (T2.getSpeed() < 0)
                            {
                                T2.setValid(true);
                            }
                            if (T3.getSpeed() < 0)
                            {
                                T3.setValid(true);
                            }
                            if (T4.getSpeed() < 0)
                            {
                                T4.setValid(true);
                            }
                            if (T5.getSpeed() < 0)
                            {
                                T5.setValid(true);
                            }
                            if (T6.getSpeed() < 0)
                            {
                                T6.setValid(true);
                            }
                            if (T7.getSpeed() < 0)
                            {
                                T7.setValid(true);
                            }
                        }
                    }
                }


                if (attacker.getSpeed() > 0)
                {

                    //conditions for an attack to occur
                    if (arrayOfDistances[victim.getUnitArrayPosition()] > attacker.getUnitRange() && victim.getUnitLocation() != nul && victim.getSpeed() < 0)
                    {
                        attacker.setValid(false);
                        if (victim.takeDamage(attacker.getUnitAttack(),this) == true)
                        {
                            attacker.setValid(true);

                            if (T0.getSpeed() > 0)
                            {
                                T0.setValid(true);
                            }
                            if (T1.getSpeed() > 0)
                            {
                                T1.setValid(true);
                            }
                            if (T2.getSpeed() > 0)
                            {
                                T2.setValid(true);
                            }
                            if (T3.getSpeed() > 0)
                            {
                                T3.setValid(true);
                            }
                            if (T4.getSpeed() > 0)
                            {
                                T4.setValid(true);
                            }
                            if (T5.getSpeed() > 0)
                            {
                                T5.setValid(true);
                            }
                            if (T6.getSpeed() > 0)
                            {
                                T6.setValid(true);
                            }
                            if (T7.getSpeed() > 0)
                            {
                                T7.setValid(true);
                            }
                        }
                    }
                }
            }





        }

        //used to resuse unit instances
        //finds next avaliabe space of dead unit in array of unit states.
        public int nextAvaliableUnit()
        {

            bool found = false;
            int value = -1;
            for (int index = 0; index < unitStates.Length; index ++)
            {
                if(found == false)
                {
                    if (unitStates[index] == false)
                    {
                        found = true;
                        value = index;

                    }
                }
            
            }

            return value;
        }


        //Kills units that are out of range
        public void checkUnitLocations(Unit U0, Unit U1, Unit U2, Unit U3, Unit U4, Unit U5, Unit U6, Unit U7, Unit U8, Unit U9)
        {
            for (int index = 0; index < unitLocations.Length; index ++)
            {
                if (unitLocations[index].X <= -14 | unitLocations[index].X >= 1514 )
                {
                    switch(index)
                    {
                        case 0:
                            U0.unitDeath(this,1);                           
                            break;
                        case 1:
                            U1.unitDeath(this, 1);
                            break;
                        case 2:
                            U2.unitDeath(this, 1);
                            break;
                        case 3:
                            U3.unitDeath(this, 1);
                            break;
                        case 4:
                            U4.unitDeath(this, 1);
                            break;
                        case 5:
                            U5.unitDeath(this, 1);
                            break;
                        case 6:
                            U6.unitDeath(this, 1);
                            break;
                        case 7:
                            U7.unitDeath(this, 1);
                            break;
                        case 8:
                            U8.unitDeath(this, 1);
                            break;
                        case 9:
                            U9.unitDeath(this, 1);
                            break;
                    }
                }

            }


        }
        //Set and Get methods

        public void setUnitState(bool state, int index)
        {
            unitStates[index] = state;
        }

        public bool getUnitState(int index)
        {
            if(index == -1)
            {
                //error
                return true;
            }
            else
            {
                return unitStates[index];
            }
            
        }

        public Point[] getUnitLocations()
        {
            return unitLocations;
        }
        public void setNewUnitLocation(int position, Point newLocation)
        {
            unitLocations[position] = newLocation;
        }


        public void setUnitNumber(int newNumber)
        {
            unitNumber = newNumber;
        }
        public int getUnitNumber()
        {
            return unitNumber;
        }

        public void setTotalMoney(int money)
        {
            totalMoney = money;
        }

        public int getTotalMoney()
        {
            return totalMoney;
        }
        public void setBaseHealth(int health)
        {
            baseHealth = health;
        }

        public int getbaseHealth()
        {
            return baseHealth;
        }
        public void setEnemyBaseHealth(int health)
        {
            enemyBaseHealth = health;
        }

        public int getEnemybaseHealth()
        {
            return enemyBaseHealth;
        }


        public void restartInstance()
        {
            //Declaring vriables
             unitNumber = 0;
        
            arrayOfDistances = new int[] { 0, 0, 0, 0, 0, 0, 0, 0, 0 };

            unitStates = new bool[] { false, false, false, false, false, false, false, false, false, false };

            totalMoney = 0;
            baseHealth = 100;
            enemyBaseHealth = 100;


            //Constructor defining point instances and array of unitLocations.

            Point point1 = new Point(0, 0);
            Point point2 = new Point(0, 0);
            Point point3 = new Point(0, 0);
            Point point4 = new Point(0, 0);
            Point point5 = new Point(0, 0);
            Point point6 = new Point(0, 0);
            Point point7 = new Point(0, 0);
            Point point8 = new Point(0, 0);
            Point point9 = new Point(0, 0);
            Point point10 = new Point(0, 0);

            unitLocations = new Point[] { point1, point2, point3, point4, point5, point6, point7, point8, point9, point10 };
        }





    }

















    






}





