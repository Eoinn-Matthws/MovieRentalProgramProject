namespace MovieRentalProgramProject
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //a Movie rental Project by Owen Matthews and Danny Huang.

            SignUpLogin login = new SignUpLogin();
            //added constructor in reference to MovieList class
            MovieList movieList = new MovieList();
            //Owen Matthews
            Console.WriteLine("----------- Movie Rental Program -----------");
            Console.WriteLine("--------------------------------------------");
            Console.WriteLine("");
            do
            {
                Console.WriteLine("");
                Console.WriteLine("1. Sign up");
                Console.WriteLine("2. Login");
                Console.WriteLine("3. Exit");
                Console.Write("Enter a option: ");
                string mainChoice = Console.ReadLine();

                switch (mainChoice)
                {
                    case "1":

                        login.SignUp();
                        break;
                    case "2":
                        login.Login();
                        break;
                    case "3":
                        Console.WriteLine("");
                        Console.WriteLine("---------------- Thank you -----------------");
                        Console.WriteLine("---------------- Goodbye!! -----------------");
                        Environment.Exit(0);
                        break;
                    default:
                        Console.WriteLine("Please enter a vaild number");
                        break;


                }//end of switch
            }while (true);

        }//end of main

       


    }//end of class Program
}//end of namespace
