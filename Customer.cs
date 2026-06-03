using System;
using System.Collections.Generic;
using System.ComponentModel.Design;
using System.Linq;
using System.Security.Authentication;
using System.Text;
using System.Threading.Tasks;

namespace MovieRentalProgramProject
{

    public class Customer
    {
        //Owen Matthews
       
        //fields
        private string username;
        private string password;

        //properties
        public string Username { get; set; }
        public string Password { get; set; }


        public static List<Movie> rentedMovies = new List<Movie>();
        //construtor
        public Customer()
        {

        }
        public Customer(string username, string password)
        {
            Username = username;
            Password = password;
        }

        // Danny Huang
        // 1/6/2026

        public void CustomerMenu()
        {
            do
            {
                Console.WriteLine("----------- Movie Rentals Menu --------------");
                Console.WriteLine("");
                Console.WriteLine("1. Search for a movie");
                Console.WriteLine("2. List a movie");
                Console.WriteLine("3. Rent a movie");
                Console.WriteLine("4. Checkout");
                Console.WriteLine("5. List all movies");
                Console.WriteLine("");
                Console.WriteLine("99. Log Out");
                Console.WriteLine("--------------------------------------------");
                Console.Write("Please enter an option: ");
                string customerChoice = Console.ReadLine();

                switch (customerChoice)
                {
                    case "1"://1/6
                        Movie.CusSearchMovie();
                        break;
                    case "2":
                        Movie.ListRandomMovie();//2/6
                        break;
                    case "3"://1/6 - if statement for boolean within RentMovie() method
                        if (Movie.RentMovie())
                        return;
                        break;
                    case "4":
                        CheckOut();
                        break;
                    case "5"://1/6
                       Movie.ListAllMovies();
                        break;
                    case "99":
                       
                        return;


                    default:
                        Console.WriteLine("Enter a vaild number");
                        break;
                }//end of switch
            } while (true);

        }//end of CustomerMenu

        //likey needs to be a child of Admin just for the search
        //this class relates to the Customer user and all their details
        
        public static void CheckOut()
        {//condition if no movies in list rentedMovies
            if (rentedMovies.Count == 0)
            {
                Console.WriteLine("No movies have been rented.");
                return;
            }

            decimal totalCost = 0;

            foreach (Movie movie in rentedMovies)
            {
                Console.WriteLine($"{movie.MovieName} - ${movie.MoviePrice}");
                totalCost += movie.MoviePrice;
            }

            Console.WriteLine($"Total Cost: ${totalCost:F2}");
        }

       
       

    }//end of customer class

}//end of namespace


