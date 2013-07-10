using System;

namespace VirtualPet
{
    /// <summary>
    /// Another C# programming project by
    /// Kevin Lockemy, July 2013
    /// </summary>

    public class Menu
    {
        public static Pet myPet = new Pet();
        public static Save newSave = new Save();
        static void Main(string[] args)
        
        {
            // Selfish Plug
            Console.WriteLine("Written in C# by Kevin Lockemy");
            Console.WriteLine("Assisted by Bryan Harmon");
            Console.WriteLine("July 10, 2013");
            Console.WriteLine("Press Enter to recognize our greatness!");
            Console.ReadLine();
            Console.Clear();

            bool quit = true;
            int choice = 1;
            myPet.name = "Bob";
            

            while (quit)
            {
                choice = Show();

                switch (choice)
                {
                    case 0:  // quit program
                        Console.WriteLine("-------------------------");
                        Console.WriteLine("Thank you for playing Virtual Pet 2.0");
                        Console.WriteLine("Press \"Enter\" to exit the program.");
                        Console.ReadLine();
                        quit = false;
                        break;
                    case 1:
                        Console.WriteLine("You talk to {0}.", myPet.name);
                        myPet.talk();
                        break;
                    case 2:
                        Console.WriteLine("You feed {0}.", myPet.name);
                        myPet.eat();
                        break;
                    case 3:
                        Console.WriteLine("You play with {0}.", myPet.name);
                        myPet.play();
                        break;
                    case 4:
                        Console.WriteLine("Oh, so you don't like my name, huh?");
                        Console.WriteLine("Then what do you think it should be?");
                        myPet.name = Console.ReadLine();
                        Console.WriteLine();
                        Console.WriteLine("Very well, my name is {0} now.", myPet.name);
                        break;
                    case 5:
                        newSave.MakeSave();
                        break;
                    case 6:
                        newSave.LoadSave();
                        break;
                    default:
                        Console.WriteLine("Invalid selection");
                        Console.WriteLine("Please enter 0, 1, 2, 3 or 4");
                        break;
                } // end switch
            } // end while loop
        } // end main method

        static int Show()
        {
            int input = 1;

            Console.WriteLine();
            Console.WriteLine();
            if (myPet.age == 1)
            {
                Console.WriteLine("{0} the chinchilla is 1 year old.", myPet.name);
            }
            else
            {
               Console.WriteLine("{0} the chinchilla is {1} years old.", myPet.name, myPet.age);
            } // end if
            Console.WriteLine();
            Console.WriteLine("0) Exit the program");
            Console.WriteLine("1) Talk to {0}.", myPet.name);
            Console.WriteLine("2) Feed {0}.", myPet.name);
            Console.WriteLine("3) Play with {0}.", myPet.name);
            Console.WriteLine("4) Rename {0}.", myPet.name);
            Console.WriteLine("5) Save your game.");
            Console.WriteLine("6) Load your saved game.");
            Console.Write(": ");
            try
            {
                input = Convert.ToInt32(Console.ReadLine());
            }
            catch (FormatException)
            {
                Console.WriteLine("Invalid entry.");
                Console.WriteLine("Please enter 0, 1, 2, 3 or 4");
            } // end try

            // age the pet
            myPet.age += 1;
            myPet.happy -= 1;
            myPet.hungry -= 1;

            if (myPet.hungry < 1)
            {
                Console.Clear();
                Console.WriteLine("You walk in to find {0} lying motionless on the floor.", myPet.name);
                Console.WriteLine("He is skin and bones and flies are buzzing over him.");
                Console.WriteLine("You should keep a closer eye on him next time.");
                return 0;
            }
            else if (myPet.happy < 1)
            {
                Console.Clear();
                Console.WriteLine("You walk in, whistling and calling for {0} but ", myPet.name);
                Console.WriteLine("you can't find him anywhere.  On the table, you ");
                Console.WriteLine("find a note from {0} saying that he is running ", myPet.name);
                Console.WriteLine("away.  You should spend more time with him next time.");
                return 0;
            }
            else
            {
                return input;
            } // end if
        } // end show method
    } // end class
} // end namespace
