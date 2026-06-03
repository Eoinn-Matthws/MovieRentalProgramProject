using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MovieRentalProgramProject
{
    // class for movie list
    // Danny Huang
    // 1/6/2026
    public class MovieList
    {
        
        //declares "movies" variable and a empty list
        public static List<Movie> movies = new List<Movie>();
        //Constructor
        public MovieList()
        {
            //movies in the list
            //hardcoded for testing purposes
            //m = stores as a decimal value
            movies.Add(new Movie("Dark Knight", "2008", "Action", "M", 5.50m, 5));
            movies.Add(new Movie("John Wick", "2014", "Action/Thriller", "R16", 6.50m, 8));
            movies.Add(new Movie("The Matrix", "1999", "Action/Sci-fi", "M", 6.50m, 8));

        }
        
        //method to add a movie
        public static void AddMovie(Movie movie)
        {
            movies.Add(movie);

        }
        

    }//end of class MovieList
}