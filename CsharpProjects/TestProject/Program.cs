// See https://aka.ms/new-console-template for more information
namespace CSharpShenanigans
{
    class Program
    {
        static void Main(string[] args) {
            Console.WriteLine("What program do you want to run?");
            String programOfChoice = Console.ReadLine();
            if (programOfChoice == "Palindrome Checker") {
                PalindromeChecker.Run();
            }
        }
    }
}