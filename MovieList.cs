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
            movies.Add(new Movie("Dark Knight", "24-07-2008", "Action", "M", 5.50m, 5));
            movies.Add(new Movie("John Wick", "27-11-2014", "Action/Thriller", "R16", 6.50m, 8));
            movies.Add(new Movie("The Matrix", "08-04-1999", "Action/Sci-fi", "M", 6.50m, 8));
            //Owen Matthews /03/06/2026
            movies.Add(new Movie("Dr No", "06-09-1962", "Spy/Action", "PG", 3.40m, 10));
            movies.Add(new Movie("Life of Brian", "08-11-1979", "Comedy/Satire", "M", 6.50m, 3));
            movies.Add(new Movie("Iron Lung", "30-01-2026", "Horror/Sci-fi", "R16", 4.10m, 5));
            movies.Add(new Movie("Project Hail Mary", "19-03-1026", "Sci-fi", "M", 7.90m, 7));

        }
        
        //method to add a movie
        public static void AddMovie(Movie movie)
        {
            movies.Add(movie);

        }
        

    }//end of class MovieList
}