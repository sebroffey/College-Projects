using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Prototype1
{
    class FreindlyGunCar
    {

        //Attributes spercific to the type of unit
        double unitSpeed = 3;
        int unitHealth = 2000;
        int unitHight = 21;
        int unitWidth = 38;
        int unitRange = -1000;
        int unitAttack = 10;
        int money = 2500;

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
