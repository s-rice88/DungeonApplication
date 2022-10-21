using DungeonLibrary;
using System.Reflection.Metadata.Ecma335;

namespace Dungeon
{
    internal class Program
    {
        //svm tab tab creates a static void Main()
        static void Main(string[] args)
        {
            //Title & Introduction

            #region Title / Introduction

            Console.Title = "DUNGEON OF DOOM";

            Console.WriteLine("Your journey begins...\n");

            #endregion

            

            //Variable to Track Score
            int score = 0;


            //TODO Weapon Object Creation
            Weapon sword = new Weapon(8, "Long Sword", 10, false, WeaponType.Sword, 1);
            Console.WriteLine(sword);//test the ToString()
            //Monster ooga = new Monster("Ooga", 10, 4, 100, 10, 4, "Very Brave Orc!");
            //Console.WriteLine(ooga);
            //Console.WriteLine($"{ooga.Name}'s damage is {ooga.CalcDamage()}");
            //TODO Player Object Creation
            //Character test = new Character("TastyTester",30,10,10000);
            //Console.WriteLine(test);

            //TODO Create the main game loop

            #region Main Game Loop


            //Counter variable - used in the condition of the loop
            bool exit = false;

            do
            {

                //TODO Generate a random room the player will enter
                Console.WriteLine();
                Console.WriteLine(GetRoom());
                Monster ooga = new Monster("Ooga", 10, 4, 100, 10 + 1, 4, "Very Brave Orc!");
                Console.WriteLine(ooga);
                Console.WriteLine($"{ooga.Name}'s damage is {ooga.CalcDamage()}");


                //Console.WriteLine(new RoomGenerator(""));//WITH LIBRARY (not best way at all)


                //TODO Select a random monster to inhabit the room

                //Create the gameplay menu loop

                #region Gameplay Menu Loop

                bool reload = false;

                

                do
                {

                    //TODO Create the main gameplay menu
                    #region MENU

                    //Prompt the user
                    Console.Write("\nPlease choose an action:\n" +
                        "A) Attack\n" +
                        "R) Run Away\n" +
                        "P) Player Info\n" +
                        "M) Monster Info\n" +
                        "X) Exit\n");

                    //Capture the user's menu selection
                    ConsoleKey userChoice = Console.ReadKey(true).Key; //Capture the pressed key, hide the key from the console, and execute immediately

                    //Clear the console
                    Console.Clear();

                    //use branching logic to act upon the users selection
                    switch (userChoice)
                    {
                        case ConsoleKey.A:

                            //TODO Combat

                            Console.WriteLine("Attack");
                            
                            break;

                            case ConsoleKey.R:

                            //TODO Run Away - Attack of Opportunity

                            Console.WriteLine("Run Away");
                            reload = true;
                            break;

                        case ConsoleKey.P:

                            //TODO Player Stats

                            Console.WriteLine("Player Info");

                            break;

                        case ConsoleKey.M:

                            //TODO Monster Stats

                            Console.WriteLine("Monster Info");

                            break;

                        case ConsoleKey.X:
                        case ConsoleKey.E:
                        case ConsoleKey.Escape:

                            //Exit

                            Console.WriteLine("Nobody likes a quitter...");

                            exit = true;

                            break;




                        default:

                            Console.WriteLine("Thou hast chosen an improper option. Triest thou again.");

                            break;
                    }//end switch

                    #region Check Player's Life Total

                    //TODO Check player's life

                    #endregion



                    #endregion



                } while (!reload && !exit);//end do while main gameplay menu

                #endregion



            } while (!exit); //keep looping as long as exit is false   //end do while




            #endregion

            //TODO Output the Final Score

            Console.WriteLine("You defeated " + score + " monster" + ((score == 1) ? "." : "s."));


            #region Terminator
            Console.ReadKey(true);//true - intercept : you won't see what the user types.
            #endregion

        }//end main ()


        private static string GetRoom()
        {
            string[] rooms = /*new string[5]*/
            {
                "The door is made of bronze, it has a turning handle with no lock\nand \"cum n\" is written with blood in common. This room has worked stones that have been cut and fitted into flagstones to make a fairly even floor. A circle with\nan inscribed six-pointed star is laid out with a fine blue sand. Investigation shows that the line elements are continuous and unbroken. The ceiling is a groin\nvaulted (semi-circular ceiling runs in both primary directions) and with a hand-sized groove carved into the ceiling from one side across to the other.\r\n\r\nThis walls\nand ceiling of this room are roughhewn. Whomever created this room did so without any regard for craftsmanship. A dented metal helmet with a bloodied feather plume\nlies discarded on the floor.\r\n\r\nThe air in the room is clear, with smoke covering the ceiling. The room smells salty and wet. A faint banging noise can\nbe heard.", "The door is made of oaken planks, it has a double-sided iron bolt and seven tally marks have been etched into the bottom of the door. This room has a\nhard-packed dirt floor. The floor gently slopes upwards to the center of the room, which is about a foot higher than the edges. The ceiling is a domed (entire ceiling is\ngently rounded) and is covered with spikes. Many are rusted, stained, bent or even broken. They are spaced regularly every foot or so and protrude down about a foot.\r\n\r\nSeveral sheets of parchment have been pasted to one wall. The ink is faded, but it appears to be an adventurer's journal, but other than some first names and\nlist of food stuffs, nothing else can be made out. The remains of half a dozen smashed ceramic jars are scattered across the floor.\r\n\r\nThe air in the room is clear\nand warm. The room smells metallic. A loud footsteps noise can be heard.", "The door is made of granite, it has a double-sided iron bolt with keyed lock and a dozen\niron nails have been hammered into the outside of this door into the shape of a circle. This room has a smoothly hewn natural stone floor. The floor gently slopes\nupwards to the center of the room, which is about a foot higher than the edges. The ceiling is a flat with wooden planks reinforced with regular wooden beams and glitters\nwith any light reflecting off the shiny carapaces of thousands of beetles that cover the entire thing.\r\n\r\nThe walls all show signs of severe damage. Numerous\ncracks and divots have been gouged into them. A rotting dwarven corpse has been spiked to the ceiling.\r\n\r\nThe air in the room is steamy. The room smells salty\nand wet. A loud chiming noise can be heard.", "The door is made of opaque brown glass, it has a turning handle with keyed lock and the bottom hinge side of the door\nhas been damaged and a portion is missing, leaving a roughly triangular section about a foot wide and high missing. This room has an irregular flagstone tile floor.\nSeveral feet from the entryway are a group of almost a dozen steel shafted spears protruding up from the floor. They are angled towards the door and appear stained\nwith old blood. Many are bent and several seem to be missing. The ceiling is a barrel vaulted with ribs (regular rounded ribs support this barrel vault ceiling) and is carved\nwith a crude map that is easily recognizable as the region outside of the dungeon.\r\n\r\nAll the walls of this room have been splattered with fresh blood, as if\nthrown onto the walls from a bucket. The blood can't be more than a day or two old. A ragged hammock is strung up with pitons in one corner of the room.\r\n\r\nThe air in the room is clear and windy. The room smells earthy. A faint banging noise can be heard."
            };
            return rooms[new Random().Next(rooms.Length)];
        }//end GetRoom()
    }//end class
}//end namespace