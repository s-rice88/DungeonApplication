﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DungeonLibrary
{
    public class Dragon : Monster
    {

        //FIELDS

        //PROPERTIES
        public bool IsScaly { get; set; }
        
        //CONSTRUCTORS
        public Dragon(string name, int hitChance, int block, int maxLife, int maxDamage, int minDamage, string description, bool isScaly) : base(name, hitChance, block, maxLife, maxDamage, minDamage, description)
        {
            IsScaly = isScaly;
            
        }
        public Dragon()
        {
            MaxLife = 6;
            MaxDamage = 3;
            Name = "Baby Dragon";
            Life = 6;
            HitChance = 25;
            Block = 20;
            MinDamage = 1;
            Description = "A freshly-hatched baby dragon. It still looks dangerous...";
            IsScaly = false;
        }


        //METHODS
        public override string ToString()
        {
            return base.ToString() + "\n" + (IsScaly ? "Coated in thick scales" : "Has a soft, underdeveloped hide");
        }
        public override int CalcBlock()
        {
            int calculatedBlock = Block;//temp variable
            //Apply a 50% increase to the rabbit's if it's fluffy
            if (IsScaly)
            {
                calculatedBlock += calculatedBlock / 2;//take 50% and round down to nearest number and add that to block
            }
            return calculatedBlock;

        }



    }
}
