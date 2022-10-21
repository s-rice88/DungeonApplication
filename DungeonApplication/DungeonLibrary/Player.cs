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
        private string? _playerDescription;
        //no fields
        //PROPERTIES
        public string? PlayerDescription
        {
            get {  return _playerDescription; }
            set { _playerDescription = value; }
        }
        public Race CharacterRace { get; set; }
        //Race CharacterRace
        public WeaponType EquippedWeapon { get; set; }
        //EquippedWeapon Weapon


        //CONSTRUCTORS
        public Player(Race characterRace, string name, string playerDescription, WeaponType equippedWeapon, int maxLife, int hitChance, int block) : base(name, hitChance, block, maxLife)
        {
            CharacterRace = characterRace;
            EquippedWeapon = equippedWeapon;
            PlayerDescription = playerDescription;
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
            Random random = new Random();
            return random.Next();
        }
        public override int CalcHitChance()
        {
            Random random = new Random();
            return random.Next();
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
            return $"------- {Name} -------\n" +
                $"{CharacterRace}\n" +
                $"{PlayerDescription}\n" +
                $"Equipped Weapon: {EquippedWeapon}\n" +
                $"Character Stats:\n" +
                $"Life: {MaxLife} Hit Chance: {HitChance} Block: {Block}\n";
            //hint, use a switch
        }



    }//end class
}//end namespace
