// See https://aka.ms/new-console-template for more information
namespace CSharpShenanigans
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("The Categories are: \n \n");
            string[] Categories = { "Math", "Game" };
            for (int i = Categories.Length - 1; i >= 0; i--)
            {
                Console.WriteLine("** " + Categories[i]);
            }
            Console.WriteLine("\n \n What Catgory would you like?");
            string CatgoryOfChoice = Console.ReadLine();
            if (CatgoryOfChoice == "Math")
            {
                MathCategory.Run();
            }
            else if (CatgoryOfChoice == "Game") {
                GameCategory.Run();
            }
            else {
                Console.WriteLine("Try Again");
                Main(args);
            }
        }
    }
}