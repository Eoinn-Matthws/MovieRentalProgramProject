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
            customers.Add(new Customer("owen", "matthews"));
        }


        //Owen Matthews 11/06/2026
        public void SignUp()
        {

            Console.WriteLine();
            Console.WriteLine("Please enter a username");
            string username = Console.ReadLine();
            if (username.ToLower() == "admin")
            {
                Console.WriteLine();
                Console.WriteLine("Invaild username");
                return;
            }
            bool KnownUser = false;

            foreach (Customer customer in customers)
            {
                if(customer.Username.Equals(username, StringComparison.OrdinalIgnoreCase))
                {
                    KnownUser = true;
                    break;
                }
            }
            if (KnownUser)
            {
                Console.WriteLine();
                Console.WriteLine("Username is taken. Please try again");
                return;
            
            }
            Console.WriteLine("Please enter a password");
            string password = Console.ReadLine();

            if (string.IsNullOrWhiteSpace(username) || string.IsNullOrWhiteSpace(password))
            {
                Console.WriteLine();
                Console.WriteLine("Username or Password can not be empty");
                return;
            
            }
            customers.Add(new Customer(username, password));
            Console.WriteLine("Account has been created successfully");
        }//end of SignUp

        public void Login()
        {
            Console.WriteLine();
            Console.WriteLine("Please enter your username");
            string username = Console.ReadLine();
            Console.WriteLine("Please enter your password");
            string password = Console.ReadLine();

            if (username == "admin" && password == "admin") //this is just to get an output will need to be changed: EDIT: Might just be the one we use. -Owen 
            {
                Console.WriteLine("");
                Admin admin = new Admin();
                admin.AdminMenu();

            }
            //Danny Huang
            //1/6/2026
            //Owen Matthews 11/06/2026
            bool loginUser = false;

            foreach (Customer customer in customers)
            {
                if (customer.Username == username && customer.Password == password)
                {
                    loginUser = true;
                    customer.CustomerMenu();
                    break;


                }
            }

                    
            if (!loginUser)
            { 
                Console.WriteLine();
                Console.WriteLine("Invalid username or password");
            }
                
        }


    }
}
