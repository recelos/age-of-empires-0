using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AgeOfEmpires0
{
    class ArmyHandler
    {
        public int Infantry { get; private set; }
        public int Cavalry { get; private set; }
        public int Catapults { get; private set; }


        public ArmyHandler()
        {
            Infantry = 0;
            Cavalry = 0;
            Catapults = 0;
        }

        public void CreateInfantry() => Infantry++;
        public void CreateCavalry() => Cavalry++;
        public void CreateCatapult() => Catapults++;

        public int CountStrength() => Infantry * 10 + Catapults * 20 + Catapults * 50;
        


    }
}
