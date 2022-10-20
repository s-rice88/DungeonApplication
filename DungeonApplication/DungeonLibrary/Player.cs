using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DungeonLibrary
{
    public class Player : Character
    {
        //FIELDS
        //no fields
        //PROPERTIES
        //Race CharacterRace
        //EquippedWeapon Weapon


        //CONSTRUCTORS
        public Player(string name, int hitChance, int block, int maxLife) : base(name, hitChance, block, maxLife)
        {
            //handle unique assignment

            //potential expansion not required
            //switch (CharacterRace)
            //{
            //      case Race.Elf:
            //          HitChance += 5;
            //          MaxHealth -= 5;
            //          break;
            //}
        }
        public Player()
        {

        }



        //METHODS

        public override int CalcDamage()
        {
            //return a random value between the weapons min and max damage
            return 0;
        }
        public override int CalcHitChance()
        {
            return 0;
            //HitChance + Weapon BonusHitChance
        }
        public override string ToString()
        {
            //create a holding variable for the description
            //Then Switch on CharacterRace property
            //description = (whatever race description is)
            //case CharacterRace.Elf:
            //  description = "Describe an Elf"
            //  break;
            return base.ToString();//+some unique description based on the players race
            //hint, use a switch
        }



    }//end class
}//end namespace
