using System;

namespace Test
{
    /// <summary>
    /// A Virtual Pet progam using OPP
    /// programming methods.
    /// by Kevin Lockemy, July 9, 2013
    /// </summary>

    class Menu
    {
        static void Main(string[] args)
        {
            // Selfish Plug
            Console.WriteLine("Written in C# by Kevin Lockemy");
            Console.WriteLine("July 9, 2013");
            Console.WriteLine("Press Enter to recognize my greatness!");
            Console.ReadLine();
            Console.Clear();

            bool quit = true;
            int choice = 1;
            Pet myPet = new Pet();
            myPet.name = "Bob";
            
            while (quit)
            {
                choice = showMenu();
                switch (choice)
                {
                    case 0:
                        Console.Clear();
                        Console.WriteLine("Thank you for playing!");
                        Console.WriteLine();
                        Console.WriteLine("Press \"Enter\" to quit the program");
                        Console.ReadLine();
                        quit = false;
                        break;
                    case 1:
                        Console.WriteLine("Hi, my name is {0}.", myPet.name);
                        if (myPet.age == 1)
                        {
                            Console.WriteLine("I am {0} year old.", myPet.age);
                        }
                        else
                        {
                            Console.WriteLine("I am {0} years old.", myPet.age);
                        } // end if
                        myPet.talk();
                        break;
                    case 2:
                        Console.WriteLine("You have fed {0}.", myPet.name);
                        myPet.feed();
                        break;
                    case 3:
                        Console.WriteLine("You have played with {0}", myPet.name);
                        myPet.play();
                        break;
                    case 4:
                        Console.WriteLine("Oh, so you don't like my name?");
                        Console.WriteLine("Then what do you think it should be?");
                        myPet.name = Convert.ToString(Console.ReadLine());
                        Console.WriteLine();
                        Console.WriteLine("Very well, my new name is {0}!", myPet.name);
                        break;
                    default:
                        Console.WriteLine("Please use the numbers 0 through 4");
                        Console.WriteLine("Please try again!");
                        break;
                } // end switch

                myPet.age += 1;
                myPet.hunger -= 1;
                myPet.happy -= 1;
            } // end while loop
        } // end main method
        
        static int showMenu()
        {
            int input = 1;

            Console.WriteLine();
            Console.WriteLine();
            Console.WriteLine();
            Console.WriteLine();
            Console.WriteLine("0) Exit the program");
            Console.WriteLine("1) Talk to your pet");
            Console.WriteLine("2) Feed your pet");
            Console.WriteLine("3) Play with your pet");
            Console.WriteLine("4) Rename your pet");

            try
            {
                input = Convert.ToInt32(Console.ReadLine());
            }
            catch (FormatException)
            {
                Console.WriteLine("Please enter a valid response.");
                input = 1;
            } // end try

            return input;
        } // end showMenu method
    } // end menu class

    class Pet
    {
        public int happy = 10;
        public int hunger = 10;
        public int age = 0;
        public string name;
        public void feed()
        {
            hunger+= 5;

        } // end feed method

        public void talk()
        {
            if (hunger >= 10)
            {
                Console.WriteLine("{0} says, \"I can't eat another bite!\"", name);
            } else if (hunger > 5)
            {
                Console.WriteLine("{0} says, \"I could go for a snack.\"", name);
            } else if (hunger > 0)
            {
                Console.WriteLine("You hear {0}'s stomach rumbling loudly!", name);
            } else 
            {
                Console.WriteLine("You find {0}'s bag of bones, curled up motionless in the corner.", name);
            } // end if

            if (happy >= 10)
            {
                Console.WriteLine("{0} looks at you with a big happy smile!", name);
            } else if (happy > 5)
            {
                Console.WriteLine("{0} walks up to you shyly, wanting to play.", name);
            } else 
            {
                Console.WriteLine("{0} sits alone in the corner, crying.", name);
            } // end if
        } // end talk method

        public void play()
        {
            happy += 3;
        } // end play method
    } // end Pet class
} // end namespace
