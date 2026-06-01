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
        public static List<Movie> movies = new List<Movie>();
        public MovieList()
        {
            movies.Add(new Movie("Dark Knight", "2008", "Action", "M", 5.50m, 5));

            
        }
        
        
        public static void AddMovie(Movie movie)
        {
            movies.Add(movie);

        }
    }//end of class MovieList
}