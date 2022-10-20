using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DungeonLibrary
{
    public class Monster : Character
    {
        //FIELDS
        //MinDamage as an int - can't be more than MaxDamage, or less than 0
        private int _minDamage;
        private int _maxDamage;
        private string? _description;
        //PROPERTIES
        public int MaxDamage
        {
            get { return _maxDamage; }
            set { _maxDamage = value; }
        }
        public string Description
        {
            get { return _description; } 
            set { _description = value; }
        }
        public int MinDamage
        {
            get { return _minDamage; }
            set
            {
                _minDamage = (value > 0 && value <= _maxDamage ? value : 1);
            }
        }
        //MinDamage as an int - can't be more than MaxDamage, or less than 0
        //MaxDamage as an int
        //Description as a string

        //CONSTRUCTORS
        public Monster()
        {
        }

        public Monster(string name, int hitChance, int block, int maxLife, int maxDamage, int minDamage, string description) : base(name, hitChance, block, maxLife)
        {
            //Remember to set MaxDamage first!!!
            MaxDamage = maxDamage;
            MinDamage = minDamage;
            Description = description;
        }

        //METHODS

        public override string ToString()
        {
            return $"--------- {Name} ---------\n" +
                   $"{Description}" +//Description
                   $"\nLife: {Life} of {MaxLife}\n" +
                   $"Damage: {MinDamage} to {MaxDamage}\n" +
                   //MinDamage to MaxDamage
                   $"Hit Chance: {HitChance}%\n" +
                   $"Block: {Block}\n";
                   
        }

        public override int CalcDamage()
        {
            Random random = new Random();
            
            return random.Next(MinDamage, MaxDamage +1);
            //return a random number between Monster min and max damage

        }

    }
}
