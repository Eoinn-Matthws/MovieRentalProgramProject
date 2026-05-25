using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Channels;
using System.Threading.Tasks;

namespace MovieRentalProgramProject
{
    public class Admin
    {
        //this class relates to the Admin user
        //Owen Matthews
        public static void AdminMenu()
        {
            Console.WriteLine("1. Add a new Movie");
            Console.WriteLine("2. Remove an existing movie");
            Console.WriteLine("3. Update a Movies details");
            Console.WriteLine("4. Search for a Movies");
            Console.WriteLine("5. List all Movies");
            Console.WriteLine("99. Exit");
            Console.Write("Please enter an option: ");
            string adminChoice = Console.ReadLine();

            switch (adminChoice)
            {
                case "1":
                    Console.WriteLine();
                break;
                case "2":
                    Console.WriteLine();
                    break;
                case "3":
                    Console.WriteLine();
                    break;
                case "4":
                    Console.WriteLine();
                    break;
                case "5":
                    Console.WriteLine();
                    break;
                case "99":
                    Console.WriteLine("---------------- Thank you -----------------");
                    Console.WriteLine("--------------------------------------------");
                    Environment.Exit(0);
                    break;
            }


        }//end of AdminMenu
    }//end of class Admin
}//end of namespace
