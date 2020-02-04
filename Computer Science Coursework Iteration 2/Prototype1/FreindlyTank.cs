using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Prototype1
{
    public class FreindlyTank
    {
        //Attributes spercific to the type of unit
        double unitSpeed = 1;
        int unitHealth = 500;
        int unitHight = 21;
        int unitWidth = 62;
        int unitRange = -200;
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
