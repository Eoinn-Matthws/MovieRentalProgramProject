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
                Console.WriteLine("2. List random movie");
                Console.WriteLine("3. Rent a movie");
                Console.WriteLine("4. View cart");
                Console.WriteLine("5. Remove a movie in cart");
                Console.WriteLine("6. List all movies");
                Console.WriteLine("");
                Console.WriteLine("99. Log Out");
                Console.WriteLine("--------------------------------------------");
                Console.Write("Please enter an option: ");
                string customerChoice = Console.ReadLine();

                switch (customerChoice)
                {
                    case "1"://1/6
                        do
                        {
                            //Program.DisplayBackOption();
                            Movie.SearchMovie();
                        } 
                        while (ContinueSearch());
                        break;
                    case "2":
                        Movie.ListRandomMovie();//2/6
                        break;
                    case "3":
                        do
                        {
                          Movie.RentMovie();
                        } while (ContinueSearch());
                        break;
                    case "4":
                        //Console.WriteLine("DEBUG: ViewCart selected");
                        ViewCart();
                        break;
                    case "5":
                        RemoveMovieCart();
                        break;
                    case "6"://1/6
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

        
        public static void ViewCart()
        {//condition if no movies in list rentedMovies

            Console.WriteLine("----------- Cart --------------");
            if (rentedMovies.Count == 0)
            {
                Console.WriteLine("Cart is empty");
                return;
            }
            Console.WriteLine("");
            Console.WriteLine($"In Cart: {rentedMovies.Count}");

            decimal totalCost = 0;

            foreach (Movie movie in rentedMovies)
            {
                
                Console.WriteLine($"{movie.MovieName} - ${movie.MoviePrice}");
                totalCost += movie.MoviePrice;
            }

            Console.WriteLine($"Total Cost: ${totalCost:F2}");
            Console.WriteLine($"Do you want to check out? (y/n)");
            string userInput = Console.ReadLine().ToLower();

            if (userInput == "y")
            {
                CheckOut();
                return;
            }
                else if (userInput == "n")
                {
                    Console.WriteLine($"Returning to menu...");
                    return;
                }
                else
                {
                    Console.WriteLine($"Invalid input. Returning to menu...");
                    return;
            }
        }//end of viewCart method

        public static void CheckOut()
        {
            Console.WriteLine("----------- Check Out --------------");
            decimal totalCost = 0;
    
                foreach (Movie movie in rentedMovies)
                {
                    totalCost += movie.MoviePrice;
                }
    
                //Console.WriteLine($"Total Cost: ${totalCost:F2}");
                Console.WriteLine($"Thank you for your purchase!");
                //clears the cart after checkout
                rentedMovies.Clear();
        }// end of CheckOut method

        //method for customer confirmation of adding movie to cart
        public static void CusCartConfirm(Movie movie)
        {
            string userInput;

            //do while loop to validate user input for adding movie to cart until user input is either "y" or "n"
            do
            {

                Console.WriteLine($"Do you want to put movie into cart? (y/n)");
                //.ToLower () converts inputted field to lower case letters therefore making it case-insensitive
                userInput = Console.ReadLine().ToLower();

                if (userInput == "y")
                {
                    rentedMovies.Add(movie);
                    Console.WriteLine($"Added to cart!");
                    Console.WriteLine($"Cart Count: {rentedMovies.Count}");
                    break;
                }
                else if (userInput == "n")
                {
                    Console.WriteLine($"Movie not added to cart");
                
                }
                else
                {
                    Console.WriteLine($"Invalid input. Please enter 'y' or 'n'.");
                }


            } while (userInput != "y" && userInput != "n");
        }//end of CusCartConfirm method

        public static bool ContinueSearch()
        {//initialize the string variable
            string userInput;

            do
            {
                Console.WriteLine("Do you want to search for another movie? (y/n)");
                userInput = Console.ReadLine().ToLower();

                if (userInput == "y")
                {
                    return true;
                }
                else if (userInput == "n")
                {
                    Console.WriteLine("Have a good day!"); //This should be different - Owen 07/06/2026
                    return false;
                } 
                else
                {
                    Console.WriteLine("Invalid input. Please enter y or n.");
                }

            } while (true);
        }//end of ContinueSearch method

        public static void RemoveMovieCart()
        {
            Console.WriteLine("----------- Removing a Movie --------------");
            Console.WriteLine("Enter the name of the movie you want to remove from cart");
                string movieToRemove = Console.ReadLine().ToLower();
                Movie movieRemove = MovieList.movies.Find(m => m.MovieName.Equals(movieToRemove, StringComparison.OrdinalIgnoreCase));

            if (movieToRemove != null)
                {
                    rentedMovies.Remove(movieRemove);
                    Console.WriteLine($"'{movieToRemove}' has been removed from your cart.");
                }

        }//end of RemoveMovieCart

    }//end of customer class

}//end of namespace


