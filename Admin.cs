using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Channels;
using System.Threading.Tasks;
using System.Transactions;

namespace MovieRentalProgramProject
{
    public class Admin
    {
        //this class relates to the Admin user
        //Owen Matthews

        public List<Movie> movieDatabase = new List<Movie>();

        public Admin()
        {

        }

        public Admin(string username, string password)
        {

        }


        public void AdminMenu()
        {
            do
            {


                Console.WriteLine("----------- Administration Menu --------------");
                Console.WriteLine("");
                Console.WriteLine("1. Add a new Movie");
                Console.WriteLine("2. Remove an existing movie");
                Console.WriteLine("3. Update a Movies details");
                Console.WriteLine("4. Search for a Movies");
                Console.WriteLine("5. List all Movies");
                Console.WriteLine("99. Exit");
                Console.Write("Please enter an option: ");
                string adminChoice = Console.ReadLine();

                switch (adminChoice)
                {
                    case "1": //done
                        NewMovie();
                        break;
                    case "2": //done
                        RemoveMovie();
                        break;
                    case "3": //not working
                        UpdateMovie();
                        break;
                    case "4":
                        Movie.SearchMovie();
                        break;
                    case "5": //done
                        Movie.ListAllMovies();
                        break;
                    case "99":
                        return;
                        break;
                    default:
                        Console.WriteLine("Enter a vaild number");
                        break;
                }//end of switch
            } while (true);

        }//end of AdminMenu


        public void NewMovie()
        {
            Console.WriteLine("----------- Adding a New Movie --------------");
            Console.WriteLine("");
            Console.WriteLine("Enter the Title of the Movie");
            string MovieName = Console.ReadLine();
            Console.WriteLine("Enter the release date of the movie (dd-mm-yyyy)");
            string ReleaseDate = Console.ReadLine();
            Console.WriteLine("Enter the genre of the movie");
            string GenreMovie = Console.ReadLine();
            Console.WriteLine("Enter the content rating of the movie (G/PG/M/R18");
            string ContentRating = Console.ReadLine();
            Console.WriteLine("Enter the price of the movie");
            decimal MoviePrice = Decimal.Parse(Console.ReadLine());
            Console.WriteLine("Enter the number of copies");
            int Copies = Int32.Parse(Console.ReadLine());

            Movie movie = new Movie(MovieName, ReleaseDate, GenreMovie, ContentRating, MoviePrice, Copies);
            MovieList.movies.Add(movie);
            Console.WriteLine($"‘{MovieName}’ has been successfully added. ");
            Console.WriteLine();
            //Movie movie = new Movie(MovieName,ReleaseDate,GenreMovie,ContentRating,MoviePrice,Copies); //unsure if this works at the moment
        }//end of NewMovie

        public void RemoveMovie()
        {
            Console.WriteLine("----------- Removing a Movie --------------");
            Console.WriteLine();
            Console.WriteLine("Enter the name of the Movie that will be removed");
            string removeMovieName = Console.ReadLine();
            Movie movieRemove = MovieList.movies.Find(m=> m.MovieName.Equals(removeMovieName,StringComparison.OrdinalIgnoreCase));

            if (movieRemove != null)
            {
                MovieList.movies.Remove(movieRemove);
                Console.WriteLine($"{movieRemove.MovieName} was removed");
            }
            
        }//end of RemoveMovie

        public void UpdateMovie()
        {
            //unsure how to do this at the moment



        }//end of UpdateMovie





    }//end of class Admin
}//end of namespace
