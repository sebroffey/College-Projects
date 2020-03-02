using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Prototype1
{
    class EnemyRocketTruck
    {
        //Attributes spercific to the type of unit
        double unitSpeed = -2.5;
        int unitHealth = 2500;
        int unitHight = 21;
        int unitWidth = 52;
        int unitRange = 200;
        int unitAttack = 700;
        int money = 1000;


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
