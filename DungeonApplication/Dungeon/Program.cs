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

            //TODO Player Object Creation



            //TODO Create the main game loop

            #region Main Game Loop


            //Counter variable - used in the condition of the loop
            bool exit = false;

            do
            {

                //TODO Generate a random room the player will enter

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
    }//end class
}//end namespace