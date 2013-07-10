using System;
using System.Text;
using System.IO;

namespace VirtualPet
{
    public class Save
    {
        public static String PersonalFolder = Environment.GetFolderPath(Environment.SpecialFolder.Personal);
        public void MakeSave()
        {
            string[] saveData = {Menu.myPet.name, Convert.ToString(Menu.myPet.age), Convert.ToString(Menu.myPet.hungry), Convert.ToString(Menu.myPet.happy) };
            System.IO.File.WriteAllLines(PersonalFolder + @"\virtualpet.sav", saveData);
            Console.WriteLine();
            Console.WriteLine("Your game has been saved successfully.");
            Console.WriteLine();
            Console.WriteLine("Press \"Enter\" to return to the game");
            Console.ReadLine();
        } // end makesave method

        public void LoadSave()
        {
            bool success = false;
            try
            {
                string[] loadData = System.IO.File.ReadAllLines(PersonalFolder + @"\virtualpet.sav");
                string Lname = loadData[0];
                int Lage = Convert.ToInt32(loadData[1]);
                int Lhungry = Convert.ToInt32(loadData[2]);
                int Lhappy = Convert.ToInt32(loadData[3]);
                Menu.myPet.name = Lname;
                Menu.myPet.age = Lage;
                Menu.myPet.hungry = Lhungry;
                Menu.myPet.happy = Lhappy;  
                success = true;
            } catch (System.IO.FileNotFoundException)
            {
                Console.WriteLine();
                Console.WriteLine("You must save a game before you can load one.");
            } finally {
                if (success) {
                    Console.WriteLine();
                    Console.WriteLine("Your game has been loaded successfully.");
                }// end if handle
            } // end exception handle

            // debugging lines
            //foreach (string s in loadData)
            // {
            //   Console.WriteLine(s);
            // }
         
            Console.WriteLine();
            Console.WriteLine("Press \"Enter\" to return to the game");
            Console.ReadLine();
            // debugging lines
            //Console.WriteLine("name: {0}", Lname);
            //Console.WriteLine("age: {0}", Lage);
            //Console.WriteLine("hun: {0}", Lhungry);
            //Console.WriteLine("hap: {0}", Lhappy);
            //Console.ReadLine();

        } // end loadsave method
    } // end save class
} // end namespace
