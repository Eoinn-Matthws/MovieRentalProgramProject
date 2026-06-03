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

        //2/6/2026 - Danny Huang
        //For movie rental system list named "cart" - below code
        public static List<Movie> cart = new List<Movie>();
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
                Console.WriteLine("1. Search movies");
                Console.WriteLine("2. List random movie");
                Console.WriteLine("3. Rent movie");
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
                        SearchMovie();
                        //Movie.CusSearchMovie();
                        break;
                    case "2":
                        Movie.ListRandomMovie();//2/6
                        break;
                    case "3"://1/6 - if statement for boolean within RentMovie() method
                        AddToCart();
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

        public static void SearchMovie()
        {
            string userInput;
            //while condition to keep going until user finds a movie that is within the MovieList class
            while (true)
            {
                //for user input of a movie name
                Console.Write("Enter movie name: ");
                //stores user input
                string search = Console.ReadLine();

                //boolean variable "found" to check if the movie is found within the MovieList class
                bool found = false;

                //when movie is found within MovieList class, it will display the movie name and price to the user and ask if they want to put it into cart
                //technically the movie variable is used for a temporary list to store the movie that is being searched for and then added to cart if user wants to rent it
                foreach (Movie movie in MovieList.movies)
                {
                    if (movie.MovieName.ToLower() == search.ToLower())
                    {
                        found = true;

                        Console.WriteLine($"'{movie.MovieName}' is available for rental, costs ${movie.MoviePrice}");
                        Console.WriteLine("Do you want to put it into cart? y/n");

                        userInput = Console.ReadLine();
                        //if user input is "y" do the following
                        if (userInput.ToLower() == "y")
                        {
                            //adds movie to cart list
                            cart.Add(movie);

                            Console.WriteLine($"{movie.MovieName} added to cart.");
                        }
                        else
                        {
                            Console.WriteLine("Movie not added to cart.");
                        }
                        //returns the value back to the class that called it
                        return;

                    }
                }

                // if condition if movie is not found within the database of movies, it will display this message to the user and ask if they want to search again
                if (!found)
                {
                    Console.WriteLine("Movie not found. Please try again");
                }


            }

        }//end of SearchMovie() method 

        //method to add movie to cart
        public static void AddToCart()
        {
            Console.Write("Enter movie name: ");
            string movieName = Console.ReadLine();

            foreach (Movie movie in MovieList.movies)
            {
                if (movie.MovieName.ToLower() == movieName.ToLower())
                {
                    cart.Add(movie);
                    Console.WriteLine($"{movie.MovieName} added to cart.");
                    return;
                }
            }

            Console.WriteLine("Movie not found.");
        }//end of AddToCart method

        //method to view cart contents
        public static void ViewCart()
        {
            decimal total = 0;

            Console.WriteLine("\n----- Shopping Cart -----");

            foreach (Movie movie in cart)
            {
                Console.WriteLine(movie);
                total += movie.MoviePrice;
            }

            Console.WriteLine($"\nTotal: ${total}");
        }//end of ViewCart method

        //method for checkout with total price
        public static void CheckOut()
        {//condition if no movies in list "cart"
            if (cart.Count == 0)
            {
                Console.WriteLine("Cart is empty.");
                return;
            }

            //declaration of variable "totalCost" to store the total cost of the movies in the cart
            decimal totalCost = 0;

            foreach (Movie movie in cart)
            {
                Console.WriteLine($"{movie.MovieName} - ${movie.MoviePrice}");
                totalCost += movie.MoviePrice;
            }

            Console.WriteLine($"Total Cost: ${totalCost:F2}");

            //confirming checkout with customer input
            Console.WriteLine("Confirm checkout? y/n");
            string input = Console.ReadLine();

            if (input.ToLower() == "y")
            {
                //using clear() method to clear cart after checkout
                cart.Clear();

                Console.WriteLine("Checkout successful!");
                Console.WriteLine("Enjoy your movies!");

            }
            else
            {

                Console.WriteLine("Checkout cancelled.");

            }


        }// end of CheckOut method


    }//end of customer class

}//end of namespace


