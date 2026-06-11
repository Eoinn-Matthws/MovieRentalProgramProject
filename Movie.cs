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
        private DateOnly releaseDate;
        private string genreMovie;
        private string contentRating;
        private decimal moviePrice;
        private int copies;

        //string rentedMovies;

        public static List<Movie> rentedMovies = new List<Movie>();
        //properties
        public string MovieName { get { return movieName; } set { movieName = value; } }
        public DateOnly ReleaseDate { get { return releaseDate; } set { releaseDate = value; } }
        public string GenreMovie { get { return genreMovie; } set { genreMovie = value; } }
        public string ContentRating { get { return contentRating; } set { contentRating = value; } }
        public decimal MoviePrice { get { return moviePrice; } set { moviePrice = value; } }
        public int Copies { get { return copies; } set { copies = value; } }

        //constructor
        public Movie()
        {

        }

        public Movie(string MovieName, DateOnly ReleaseDate, string GenreMovie, string ContentRating, decimal MoviePrice, int Copies)
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
            Console.WriteLine("----------- Search a Movie --------------");
            Console.WriteLine("");
            Console.WriteLine("Please enter the Title of the Movie");
            string movieName = Console.ReadLine();
            //initialize bool variable for false
            bool found = false;

            foreach (Movie movie in MovieList.movies)
            {
                //Console.WriteLine($"DEBUG: '{movie.MovieName}'");
                if (movie.MovieName.ToLower() == movieName.ToLower())
                {
                    Console.WriteLine("");
                    Console.WriteLine("Movie Found!");
                    Console.WriteLine($"Title: {movie.MovieName}");
                    Console.WriteLine($"Price: ${movie.MoviePrice}");
                    Console.WriteLine($"Copies Available: {movie.Copies}");
                    Console.WriteLine("");
                    //calls method from Customer class to confirm if they want to add it to their cart
                    Customer.CusCartConfirm(movie);
                    //once found is true it will break out of the loop and not display "Movie not found"
                    found = true;
                    break;
                }


            }//if not found after going through the whole list it will display "Movie not found"
            if (!found)
            {
                Console.WriteLine("Movie not found.");
                //exit loop 
                found = true;
                
            }

        }

        
        //Rent Movie method
        public static void RentMovie()
        {

            Console.Write("Enter the name of the movie you want to rent: ");
            string movieToRent = Console.ReadLine();

            bool found = false;
            foreach (Movie movie in MovieList.movies)
            {// .ToLower() converts inputted field to lower case letters therefore making it case-insensitive
                if (movie.MovieName.ToLower() == movieToRent.ToLower())
                {
                    Customer.CusCartConfirm(movie);
                    found = true;
                    break;
                }
                //if not found after going through the whole list it will display "Movie not found"
                if (!found)
                    {
                        Console.WriteLine("Movie not found.");
                         //exit loop 
                        found = true;

                }
                
            }//end of foreach in RentMovie() method

        }//end of RentMovie() Method
        public static void ListRandomMovie()
        {

            Console.WriteLine("");
            Console.WriteLine("----------- Random Movie --------------");
           
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
            Console.WriteLine("");

        }
        public static void ListAllMovies()
        {
            Console.WriteLine("");
            Console.WriteLine("----------- List of all Movies --------------");

            foreach (Movie movie in MovieList.movies)
            {
                Console.WriteLine($"Title: {movie.MovieName}");
                Console.WriteLine($"Release date: {movie.ReleaseDate}");
                Console.WriteLine($"Genre: {movie.GenreMovie}");
                Console.WriteLine($"Content Rating: {movie.ContentRating}");
                Console.WriteLine($"Price: ${movie.MoviePrice}");
                Console.WriteLine($"Copies Available: {movie.Copies}");
                Console.WriteLine("");

            }

            Console.WriteLine($"Total movies: {MovieList.movies.Count}");

        

       

        }
    }//end of class Movie
}//end of namespace
