﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DungeonLibrary
{
    public class Vampire : Monster
    {

        //FIELDS


        //PROPERTIES
        public DateTime HourChangeBack { get; set; }


        //CONSTRUCTORS

        public Vampire(string name, int hitChance, int block, int maxLife, int maxDamage, int minDamage, string description)
            : base(name, hitChance, block, maxLife, maxDamage, minDamage, description)
        {
            HourChangeBack = DateTime.Now;
            if (HourChangeBack.Hour <6 || HourChangeBack.Hour > 18)
            {
                HitChance += 10;
                Block += 10;
                MinDamage += 1;
                MaxDamage += 2;
            }
        }



        //METHODS
        public override string ToString()
        {
            return base.ToString() + 
                (HourChangeBack.Hour < 6 || HourChangeBack.Hour > 18 ?
                "Empowered by the night" : "Weakened by the daylight");
        }



    }//end class
}//end namespace
