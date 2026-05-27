using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Authentication;
using System.Text;
using System.Threading.Tasks;

namespace MovieRentalProgramProject
{
    public class Customer
    {

        //fields
        private string username;
        private string password;

        //properties
        public string Username { get; set; }
        public string Password {  get; set; }



        //construtor
        public Customer()
        {

        }
        public Customer(string username, string password)
        {
            Username = username;
            Password = password;
        }



        public void CustomerMenu()
        {
            Console.WriteLine("customer");
        }

        //likey needs to be a child of Admin just for the search
        //this class relates to the Customer user and all their details


    }
}
