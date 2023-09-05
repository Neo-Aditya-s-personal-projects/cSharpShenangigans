class CalculusSubCategory
{
    public static void Run()
    {
        Console.WriteLine("The subcategories are are: \n \n");
        string[] Subategories = { };
        for (int i = Subategories.Length - 1; i >= 0; i--)
        {
            Console.WriteLine("** " + Subategories[i]);
        }
        Console.WriteLine("\n \n What subcatgory would you like?");
        string Program = Console.ReadLine();

    }
}