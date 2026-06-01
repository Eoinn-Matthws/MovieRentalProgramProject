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




    }//end of class Movie
}//end of namespace
