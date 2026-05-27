using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MovieRentalProgramProject
{
    public class SignUpLogin
    {

        List<Customer> customers = new List<Customer>();

        public void SignUp()
        {
            Console.WriteLine();
            Console.WriteLine("Please enter a username");
            string username = Console.ReadLine();
            Console.WriteLine("Please enter a password");
            string password = Console.ReadLine();
            customers.Add(new Customer(username, password));

            //This code is not needed at the moment
            /*Console.WriteLine("Is this a Customer or Admin Account");
            string userType = Console.ReadLine();
            Console.WriteLine("");
            */

            Console.WriteLine("Account has been created successfully");
        }//end of SignUp

        public void Login()
        {
            Console.WriteLine();
            Console.WriteLine("Please enter your username");
            string username = Console.ReadLine();
            Console.WriteLine("Please enter your password");
            string password = Console.ReadLine();

            if (username == "admin" && password == "admin") //this is just to get an output will need to be changed 
            {
                Console.WriteLine("");
                Admin admin = new Admin();
                admin.AdminMenu();

            }
            else 
            {
                foreach (Customer customer in customers)
                {
                    if (customer.Username == username && customer.Password == password)
                    {
                        Console.WriteLine();
                        customer.CustomerMenu();
                    }
                    else
                    {
                        Console.WriteLine("");
                    }
                }
            }
        }


    }
}
