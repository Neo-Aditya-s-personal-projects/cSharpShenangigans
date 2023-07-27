// See https://aka.ms/new-console-template for more information
namespace CSharpShenanigans
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("The Categories are: \n \n");
            string[] Categories = {"Math"};
            for (int i = Categories.Length - 1; i >= 0; i--)
            {
                Console.WriteLine("** " + Categories[i]);
            }
            Console.WriteLine("\n \n What Catgory would you like?");
            string CatgoryOfChoice = Console.ReadLine();
            if (CatgoryOfChoice == "Math")
            {
                Console.WriteLine("The Programs are: \n \n");
                string[] Programs = {"Palindrome Checker"};
                for (int i = Categories.Length - 1; i >= 0; i--) {
                    Console.WriteLine("** " + Programs[i]);
                }
                Console.WriteLine("\n \n What program do you want to run?");
                string programOfChoice = Console.ReadLine();
                if (programOfChoice == "Palindrome Checker")
                {
                    PalindromeChecker.Run();
                }
            }
        }
    }
}