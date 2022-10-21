using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DungeonLibrary
{

    //The "Abstract" modifier:
    //Denotes this datatype class is "incomplete" -- we don't intend
    //to make a character object, but will instead use character as
    //a starting point for other, more specific types. More on this later.


    public abstract class Character
    {

        /*
        
        //props/fields
        life – int

        name – string

        hitChance – int

        block – int

        maxLife – int

        life – int
        
        //methods

        Fully Qualified CTOR

        CalcBlock() – returns the value of Block

        CalcHitChance() – returns the value of HitChance

        CalcDamage() – returns 0

        NicelyFormatted ToString()
         
         */

        //FIELDS
        private int _life;
        private string? _name;// ? just means nullable
        private int _hitchance;
        private int _block;
        private int _maxLife;



        //PROPERTIES
        public string Name
        {
            get { return _name; }
            set { _name = value; }
        }
        public int HitChance
        {
            get { return _hitchance; }
            set { _hitchance = value; }
        }
        public int Block
        {
            get { return _block; }
            set { _block = value; }
        }
        public int MaxLife
        {
            get { return _maxLife; }
            set { _maxLife = value; }
        }
        public int Life
        {
            get { return _life; }
            //life cannot be more than maxLife
            set
            {
                if (value <= _maxLife)
                {
                    _life = value;
                }//end if
                else
                {
                    _life = MaxLife;
                }//end else
                
            }
        }

                


        //CONSTRUCTORS
        public Character(string name, int hitChance, int block, int maxLife)
        {
            Name = name;
            HitChance = hitChance;
            Block = block;
            MaxLife = maxLife;
            Life = maxLife;//Default Life to be the same as MaxLife
        }

        public Character()//ctor tab tab auto create
        {

        }
        //METHODS
        public override string ToString()
        {
            return $"--------- {Name} ---------\n" +
                $"Life: {Life} of {MaxLife}\n" +
                $"Hit Chance: {HitChance}%\n" +
                $"Block: {Block}";
        }

        public virtual int CalcBlock() { return Block; }
        public virtual int CalcHitChance() { return HitChance; }
        public virtual int CalcDamage() { return 0; }


    }
}
