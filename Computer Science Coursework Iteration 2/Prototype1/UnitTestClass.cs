using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Prototype1
{
    class UnitTestClass
    {
        //Attributes spercific to the type of unit
        double unitSpeed = 1;
        int unitHealth = 0;
        int unitHight = 2;
        int unitWidth = 3;
        int unitRange = 4;
        int unitAttack = 5;

        //Gets
        public double getUnitSpeed()
        {
            return unitSpeed;
        }
        public int getUnitHealth()
        {
            return unitHealth;
        }
        public int getUnitHight()
        {
            return unitHight;
        }
        public int getUnitWidth()
        {
            return unitWidth;
        }
        public int getUnitRange()
        {
            return unitRange;
        }
        public int getUnitAttack()
        {
            return unitAttack;
        }
    }
}
    

