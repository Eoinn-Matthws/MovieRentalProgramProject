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
        // added customer login
        // hardcoded customer login details for testing
        // 1/6/26
        public SignUpLogin()
        {
            customers.Add(new Customer("danny", "huang"));
        }


        
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
                //Danny Huang
                //1/6/2026
                
                foreach (Customer customer in customers)
                {
                    if (customer.Username == username && customer.Password == password)
                    {
                        // Console.WriteLine("Please enter username: ");
                       // string Username = Console.ReadLine();

                       // Console.WriteLine("Please enter password: ");
                        // string Password = Console.ReadLine();
                        customer.CustomerMenu();
                        return;
                    }
                    else
                    {// if user enters a username or password not in the system
                        Console.WriteLine("Invalid username or password");
                    }
                }
            }
        }


    }
}
