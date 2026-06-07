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
                    case "3": //done
                        UpdateMovie();
                        break;
                    case "4":
                        AdminSearchMovie();
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
            try {
                Console.WriteLine("----------- Adding a New Movie --------------");
                Console.WriteLine("");
                Console.WriteLine("Enter the Title of the Movie");
                string MovieName = Console.ReadLine();
                Console.WriteLine("Enter the release date of the movie (dd-mm-yyyy)");
                DateOnly ReleaseDate = DateOnly.Parse(Console.ReadLine()); //changed to DateTime so it actually is stored as a date
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
            }
            catch (Exception e)
            { 
                Console.WriteLine(e.Message);
            }
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

        //Owen Matthews
        //07-06-2026
        public void UpdateMovie()
        {
            Console.WriteLine("----------- Update Movie --------------");
            Console.WriteLine();
            Console.WriteLine("Please select the movie to be update");
            string movieToUpdate= Console.ReadLine();
            // finds the movie in the list
            Movie updateMovie = MovieList.movies.Find(u=> u.MovieName.Equals(movieToUpdate,StringComparison.OrdinalIgnoreCase));

            if (updateMovie == null)
            {
                Console.WriteLine($"'{movieToUpdate}' not found ");
                return;
            }

            if (updateMovie != null)
            {
                
                Console.WriteLine("1. Title");
                Console.WriteLine("2. Release Date");
                Console.WriteLine("3. Genre");
                Console.WriteLine("4. Content Rating");
                Console.WriteLine("5. Price");
                Console.WriteLine("6. Copies");
                Console.WriteLine("Please enter which part of the movies details to update");
                string updateChoice = Console.ReadLine();
                switch (updateChoice)
                {
                    case "1":
                    {
                        Console.WriteLine($"Current title: {updateMovie.MovieName}");
                        Console.WriteLine("Enter the new title");
                        updateMovie.MovieName = Console.ReadLine();
                        Console.WriteLine("Successfully updated the title");
                        break;
                    }//end of case 1

                    case "2":
                    {
                        Console.WriteLine($"Current release date: {updateMovie.ReleaseDate}");
                        Console.WriteLine("Enter the new release date (dd-mm-yyyy)");
                        //this checks if the date is vaild and if not it will fail. it works like a Try statement but less memory is used and easier to write.
                        if (DateOnly.TryParse(Console.ReadLine(), out DateOnly updateDate))
                        {
                            updateMovie.ReleaseDate = updateDate;
                            Console.WriteLine("Successfully updated the release date");

                        }
                        else
                        {
                            Console.WriteLine("Update failed: Invalid date format");
                        }
                        break;
                    }//end of case 2
                    case "3":
                    {
                        Console.WriteLine($"Current genre: {updateMovie.GenreMovie}");
                        Console.WriteLine("Enter the new genre");
                        updateMovie.GenreMovie = Console.ReadLine();
                        Console.WriteLine("Successfully updated the genre");
                        break;
                    }//end of case 3
                    case "4":
                    {
                        Console.WriteLine($"Current content rating: {updateMovie.ContentRating}");
                        Console.WriteLine("Enter the new content rating");
                        updateMovie.ContentRating = Console.ReadLine();
                        Console.WriteLine("Successfully updated the content rating");
                        break;
                    }//end of case 4
                    case "5":
                    {
                        Console.WriteLine($"Current price: ${updateMovie.MoviePrice}");
                        Console.WriteLine("Enter the new price");
                        if (decimal.TryParse(Console.ReadLine(), out decimal updatePrice))
                        {
                            updateMovie.MoviePrice = updatePrice;
                            Console.WriteLine("Successfully updated the price");

                        }
                        else
                        {
                            Console.WriteLine("Update failed: Invalid price");
                        }
                        break;

                    }//end of case 5
                    case "6":
                    {
                        Console.WriteLine($"Current amount of copies : {updateMovie.Copies}");
                        Console.WriteLine("Enter the new amount of copies");
                        if (int.TryParse(Console.ReadLine(), out int updateCopies))
                        {
                            updateMovie.Copies = updateCopies;
                            Console.WriteLine("Successfully updated the amount of copies");

                        }
                        else
                        {
                            Console.WriteLine("Update failed: Invalid input");
                        }
                        break;
                           
                    }//end of case 6
                    default:
                    {
                            Console.WriteLine("Invalid option");
                            break;
                    }//end of default

                }

            }
            



        }//end of UpdateMovie

        public static void AdminSearchMovie()
        {
            Console.WriteLine("----------- Movie Search --------------");
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
                    Console.WriteLine($"Release date: {movie.ReleaseDate}");
                    Console.WriteLine($"Genre: {movie.GenreMovie}");
                    Console.WriteLine($"Price: ${movie.MoviePrice}");
                    Console.WriteLine($"Copies Available: {movie.Copies}");
                    Console.WriteLine("");
                
                    //once found is true it will break out of the loop 
                    found = true;
                    break;
                }


            }
            if (!found)
            {
                Console.WriteLine("Movie not found.");
                found = true;

            }

        }



    }//end of class Admin
}//end of namespace
