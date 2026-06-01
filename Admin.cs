using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Channels;
using System.Threading.Tasks;

namespace MovieRentalProgramProject
{
    public class Admin
    {
        //this class relates to the Admin user
        //Owen Matthews

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
                    case "1":
                        newMovie();
                        break;
                    case "2":
                        Console.WriteLine();
                        break;
                    case "3":
                        Console.WriteLine();
                        break;
                    case "4":
                        Console.WriteLine();
                        break;
                    case "5":
                        Console.WriteLine();
                        break;
                    case "99":
                        return;
                        break;
                    default:
                        Console.WriteLine("Enter a vaild number");
                        break;
                }//end of switch
            }while (true);

        }//end of AdminMenu


        public static void newMovie()
        {
            Console.WriteLine("");
            Console.WriteLine("Enter the Title of the Movie");
            string MovieName = Console.ReadLine();
            Console.WriteLine("Enter the release date of the movie (dd-mm-yyyy)");
            string ReleaseDate = Console.ReadLine();
            Console.WriteLine("Enter the Genre of the Movio");
            string GenreMovie = Console.ReadLine();
            Console.WriteLine("Enter the content rating of the Movie (G/PG/M/R18");
            string ContentRating = Console.ReadLine();
            Console.WriteLine("Enter the price of the movie");
            decimal MoviePrice = Decimal.Parse(Console.ReadLine());
            Console.WriteLine("Enter the number of copies");
            int Copies = Int32.Parse(Console.ReadLine());

            Movie movie = new Movie(MovieName, ReleaseDate, GenreMovie, ContentRating, MoviePrice, Copies); //unsure if this works at the moment
            MovieList.movies.Add(movie);
            Console.WriteLine($"‘{MovieName}’ has been successfully added. ");
            Console.WriteLine();
            
        }


    }//end of class Admin
}//end of namespace
