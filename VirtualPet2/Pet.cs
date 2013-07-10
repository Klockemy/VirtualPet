using System;

namespace VirtualPet
{
    public class Pet
    {
        public int age = 0;
        public int happy = 10;
        public int hungry = 10;
        public string name;

        public void talk()
        {
            if (happy > 9)
            {
                Console.WriteLine("I couldn't be any happier!");
            }
            else if (happy > 5)
            {
                Console.WriteLine("{0} tugs at your leg, \"Hey! I'm down here. Play with me!\"", name);
            }
            else
            {
                Console.WriteLine("{0} sits cowering in the corner, afraid to look in your direction", name);
            } // end happy if

            if (hungry > 9)
            {
                Console.WriteLine("I'm stuffed!  I can't eat another bite!");
            }
            else if (hungry > 5)
            {
                Console.WriteLine("{0} eyes the bag of pet food on the shelf", name);
            }
            else
            {
                Console.WriteLine("You hear {0}'s stomach rumbling from across the room", name);
            } // end hungry if
        } // end talk method

        public void eat()
        {
            hungry += 4;
        } // end eat method

        public void play()
        {
            happy += 3;
        } // end play method
    } // end Pet class
} // end namespace
