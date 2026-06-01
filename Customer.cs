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
                        CusMovie();
                        break;
                    case "2":
                        Console.WriteLine();
                        break;
                    case "3"://1/6 - if statement for boolean within RentMovie() method
                        if (RentMovie())
                        return;
                      break;
                    case "4":
                        Console.WriteLine();
                        break;
                    case "5"://1/6
                        ListAllMovies();
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
        public void CusMovie()
        {
            Console.WriteLine("");
            Console.WriteLine("Please enter the Title of the Movie");
            string movieName = Console.ReadLine();

            foreach (Movie movie in MovieList.movies)
            {
                if (movie.MovieName.ToLower() == movieName.ToLower())
                {
                    Console.WriteLine("Movie Found!");
                    Console.WriteLine($"Title: {movie.MovieName}");
                    Console.WriteLine($"Price: ${movie.MoviePrice}");
                    Console.WriteLine($"Copies Available: {movie.Copies}");
                    Console.WriteLine("");
                    return;
                }
            }
            //if movie is not found display this message to the user
            Console.WriteLine("Movie not found.");
        }
        //Rent Movie method
        public static bool RentMovie()
        {
            Console.Write("Enter the name of the movie you want to rent: ");
            string movieToRent = Console.ReadLine();
            string userInput;
            string userInput2;
            string userInput3;

            foreach (Movie movie in MovieList.movies)
            {
                if (movie.MovieName.ToLower() == movieToRent.ToLower())
                {
                    Console.WriteLine($"'{movie.MovieName}'is available for rental, costs ${movie.MoviePrice}");
                    Console.WriteLine($"Do you want to rent it? y/n");
                    userInput = Console.ReadLine();


                    if (userInput.ToLower() == "y")
                    {
                        Console.WriteLine($"That will be {movie.MoviePrice}. Are you sure? y/n");
                        userInput2 = Console.ReadLine();

                        if (userInput2.ToLower() == "y")
                        {
                            Console.WriteLine("Thanks for renting!");
                            Console.WriteLine("Enjoy the movie!!");
                        }
                        else
                        {
                            Console.WriteLine("Enjoy your day");
                            Console.WriteLine("See you again!");
                        }
                    }
                    else
                    {
                        Console.WriteLine("Enjoy your day");
                        Console.WriteLine("See you again!");
                    }

                    return true;
                }
            }//end of foreach in RentMovie() method
            
                Console.WriteLine("Movie not found.");
                Console.WriteLine("Do you want to search for another movie? y/n");
                userInput3 = Console.ReadLine();

            if (userInput3.ToLower() == "y")
            {
                return RentMovie();
            }
            else
            {// if boolean is true it will go back to do while loop 
                return true;
            }
            
        }//end of RentMovie() Method

        
        public static void ListAllMovies()
        {
            Console.WriteLine("");
            Console.WriteLine("----------- List of Movies --------------");

            foreach (Movie movie in MovieList.movies)
            {
                Console.WriteLine($"Title: {movie.MovieName}");
                Console.WriteLine($"Price: ${movie.MoviePrice}");
                Console.WriteLine($"Copies Available: {movie.Copies}");
                Console.WriteLine("");
                
            }

            Console.WriteLine($"Total movies: {MovieList.movies.Count}");

        }


    }//end of customer class

}//end of namespace


