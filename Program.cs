namespace MovieRentalProgramProject
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //a Movie rental Project by Owen Matthews and Danny Huang.


            //Owen Matthews
            Console.WriteLine("----------- Movie Rental Program -----------");
            Console.WriteLine("--------------------------------------------");
            Console.WriteLine("");

            Console.WriteLine("1. Sign up");
            Console.WriteLine("2. Login in");
            Console.WriteLine("3. Exit");
            Console.Write("Enter a option: ");
            string mainChoice = Console.ReadLine();

            switch (mainChoice)
            {
                case "1":
                    Console.WriteLine();
                    Console.WriteLine("Sign up");
                    break;
                case "2":
                    Console.WriteLine("");
                    Console.WriteLine("Please enter your username");
                    Console.ReadLine();
                    Console.WriteLine("Please enter your password");
                    Console.ReadLine();
                    break;
                case "3":
                    Console.WriteLine("");
                    Console.WriteLine("---------------- Thank you -----------------");
                    Console.WriteLine("--------------------------------------------");
                    Environment.Exit(0);
                    break;
                default:
                    Console.WriteLine("Please enter a vaild number");
                    break;


            }//end of switch


        }//end of main
    }//end of class Program
}//end of namespace
