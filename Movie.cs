using System;
using System.Collections.Generic;
using System.Linq;
using System.Reflection.Metadata.Ecma335;
using System.Security.AccessControl;
using System.Text;
using System.Threading.Tasks;

namespace MovieRentalProgramProject
{
    //this class is for all of the movies infomation
    public class Movie
    {
        //Owen Matthews
        //fields
        private string movieName;
        private string releaseDate;
        private string genreMovie;
        private string contentRating;
        private decimal moviePrice;
        private int copies;

        //string rentedMovies;

        public static List<Movie> rentedMovies = new List<Movie>();
        //properties
        public string MovieName { get { return movieName; } set { movieName = value; } }
        public string ReleaseDate { get { return releaseDate; } set { releaseDate = value; } }
        public string GenreMovie { get { return genreMovie; } set { genreMovie = value; } }
        public string ContentRating { get { return contentRating; } set { contentRating = value; } }
        public decimal MoviePrice { get { return moviePrice; } set { moviePrice = value; } }
        public int Copies { get { return copies; } set { copies = value; } }

        //constructor
        public Movie()
        {

        }

        public Movie(string MovieName, string ReleaseDate, string GenreMovie, string ContentRating, decimal MoviePrice, int Copies)
        {
            movieName = MovieName;
            releaseDate = ReleaseDate;
            genreMovie = GenreMovie;
            contentRating = ContentRating;
            moviePrice = MoviePrice;
            copies = Copies;

        }
        // without this ToString method it displays "MovieRentalProgramProject.Movie"
        public override string ToString()
        {
            return $"{movieName} ({releaseDate}) - {genreMovie} - Rating: {contentRating} - ${moviePrice} - Copies: {copies}";
        }
        public static void SearchMovie()
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
            {// .ToLower() converts inputted field to lower case letters therefore making it case-insensitive
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
                           rentedMovies.Add(movie);

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
        public static void ListRandomMovie()
        {

            Console.WriteLine("");
            Console.WriteLine("----------- List a Movie --------------");

            //for debugging
            //Console.WriteLine($"Movie count = {MovieList.movies.Count}");

            //uses Random class that is built into C# 
            //stores that into a variable called "random"
            Random random = new Random();

            //gets the number of movies in the list 
            //random.Next generates a random number from the index/MovieList
            int index = random.Next(MovieList.movies.Count);

            //gets movie at that index number starting at 0
            Movie movie = MovieList.movies[index];

            //displays the movie
            Console.WriteLine(movie);


        }
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

    }//end of class Movie
}//end of namespace
