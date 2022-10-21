using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DungeonLibrary
{
    public class Rabbit : Monster
    {
        //FIELDS

        //PROPERTIES
        public bool IsFluffy { get; set; }
        //CONSTRUCTORS
        //Default Ctor to set some basic values for a generic monstser of this type
        public Rabbit()
        {
            MaxLife = 6;
            MaxDamage = 3;
            Name = "Baby Rabbit";
            Life = MaxLife;
            HitChance = 20;
            Block = 20;
            MinDamage = 1;
            Description = "It's just a cute little bunny... why would you hurt it?";
            IsFluffy = false;
        }
        //Parent complaint (Monster) Ctor
        //Intellisense quick action on the Parent name in the class declaration
        public Rabbit(string name, int hitChance, int block, int maxLife, int maxDamage, int minDamage, string description,bool isFluffy)
            : base(name, hitChance, block, maxLife, maxDamage, minDamage, description)
        {
            IsFluffy = isFluffy;
        }

        public override string ToString()
        {
            return base.ToString() + (IsFluffy ? "It's Fluffy" : "It's not so fluffy");
        }

        //Character CalcBlock = Block
        //Monster CalcBlock = Block
        //Rabbit CalcBlock = check see IsFluffy then CalcBlock

        public override int CalcBlock()
        {
            int calculatedBlock = Block;//temp variable
            //Apply a 50% increase to the rabbit's if it's fluffy
            if (IsFluffy)
            {
                calculatedBlock += calculatedBlock / 2;//take 50% and round down to nearest number and add that to block
            }
            return calculatedBlock;

        }


        //METHODS
    }
}
