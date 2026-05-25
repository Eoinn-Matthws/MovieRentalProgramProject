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
            Console.WriteLine("2. Login");
            Console.WriteLine("3. Exit");
            Console.Write("Enter a option: ");
            string mainChoice = Console.ReadLine();

            switch (mainChoice)
            {
                case "1":
                    SignUp();
                    break;
                case "2":
                    Login();
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

        public static void SignUp()
        {
            Console.WriteLine("Please enter a username");
            string username = Console.ReadLine();
            Console.WriteLine("Please enter a password");
            string password = Console.ReadLine();

            Console.WriteLine("Is this a Customer or Admin Account");
            string userType = Console.ReadLine();
            if (userType == "admin")
            {
                //store the results in the Admin class 

            }
            else
            {
                //Store th results in the Customer class
            }
                
            Console.WriteLine("Account has been createdd successfully");
        }//end of SignUp

        public static void Login()
        {
            Console.WriteLine("Please enter your username");
            Console.ReadLine();
            Console.WriteLine("Please enter your password");
            Console.ReadLine();
        }


    }//end of class Program
}//end of namespace
