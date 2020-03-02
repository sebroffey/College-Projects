using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Prototype1
{
    class FreindlyHumvee
    {
        //Attributes spercific to the type of unit
        double unitSpeed = 2.5;
        int unitHealth = 3000;
        int unitHight = 16;
        int unitWidth = 29;
        int unitRange = -400;
        int unitAttack = 15;
        int money = 1500;


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
        public int getUnitMoney()
        {
            return money;
        }



    }
}
