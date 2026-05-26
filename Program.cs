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
            }while (true);

        }//end of main

        public static void SignUp()
        {
            Console.WriteLine();
            Console.WriteLine("Please enter a username");
            string username = Console.ReadLine();
            Console.WriteLine("Please enter a password");
            string password = Console.ReadLine();

            Console.WriteLine("Is this a Customer or Admin Account");
            string userType = Console.ReadLine();
            Console.WriteLine("");
                
            Console.WriteLine("Account has been created successfully");
        }//end of SignUp

        public static void Login()
        {
            Console.WriteLine();
            Console.WriteLine("Please enter your username");
            string username = Console.ReadLine();
            Console.WriteLine("Please enter your password");
            string password = Console.ReadLine();
            
            if ( username == "admin") //this is just to get an output will need to be changed 
            {
                Console.WriteLine("");
                Admin admin = new Admin();
                admin.AdminMenu();

            }
            else
            {
                //Store th results in the Customer class
            }
        }


    }//end of class Program
}//end of namespace
