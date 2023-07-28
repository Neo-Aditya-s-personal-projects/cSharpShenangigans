class CheckerSubCategory
{
    public static void Run()
    {
        Console.WriteLine("The programs are are: \n \n");
        string[] Programs = { "Palindrome", "Prime" };
        for (int i = Programs.Length - 1; i >= 0; i--)
        {
            Console.WriteLine("** " + Programs[i]);
        }
        Console.WriteLine("\n \n What subcatgory would you like?");
        string Program = Console.ReadLine();
        if (Program == "Palindrome")
        {
            PalindromeChecker.Run();
        }
        else if (Program == "Prime")
        {
            PrimeChecker.Run();
        }
        else {
            Console.WriteLine("Try Again"); 
            Run();
        }
    }
}