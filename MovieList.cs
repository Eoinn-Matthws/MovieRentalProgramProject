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
    public class MovieList:Movie
    {
        
        //declares "movies" variable and a empty list
        public static List<Movie> movies = new List<Movie>();
        //Constructor
        public MovieList()
        {
            //movies in the list
            //hardcoded for testing purposes
            //m = stores as a decimal value

            //Owen Matthews 07/06/2026
            //DateTime.ParseExact(date, dd-MM-yyyy, null) defines the dates and their format.
            //null is just because it's meant to be culture info incase someone has there PC set to a non day-month-year format
            movies.Add(new Movie("Dark Knight", DateOnly.ParseExact("24-07-2008", "dd-MM-yyyy", null), "Action", "M", 5.50m, 5));
            movies.Add(new Movie("John Wick", DateOnly.ParseExact("27-11-2014", "dd-MM-yyyy", null), "Action/Thriller", "R16", 8.50m, 8));
            movies.Add(new Movie("The Matrix", DateOnly.ParseExact("08-04-1999", "dd-MM-yyyy", null), "Action/Sci-fi", "M", 6.50m, 8));
            movies.Add(new Movie("The Lord of the Rings: The Return of the King", DateOnly.ParseExact("03-12-2003", "dd-MM-yyyy", null), "Action/Fantasy", "M", 6.50m, 8));
            movies.Add(new Movie("Alien", DateOnly.ParseExact("24-01-1980", "dd-MM-yyyy", null), "Horror/Sci-fi", "R", 4.50m, 6));
            movies.Add(new Movie("Avatar", DateOnly.ParseExact("18-12-2009", "dd-MM-yyyy", null), "Action/Adventure", "M", 7.50m, 8));
            //Owen Matthews /03/06/2026
            movies.Add(new Movie("Dr No", DateOnly.ParseExact("06-09-1962", "dd-MM-yyyy", null), "Spy/Action", "PG", 3.40m, 10));
            movies.Add(new Movie("Life of Brian", DateOnly.ParseExact("08-11-1979", "dd-MM-yyyy", null), "Comedy/Satire", "M", 6.50m, 3));
            movies.Add(new Movie("Iron Lung", DateOnly.ParseExact("30-01-2026", "dd-MM-yyyy", null), "Horror/Sci-fi", "R16", 4.10m, 5));
            movies.Add(new Movie("Project Hail Mary", DateOnly.ParseExact("19-03-2026", "dd-MM-yyyy", null), "Sci-fi", "M", 7.90m, 7));

        }
        
        //method to add a movie
        public static void AddMovie(Movie movie)
        {
            movies.Add(movie);

        }
        

    }//end of class MovieList
}