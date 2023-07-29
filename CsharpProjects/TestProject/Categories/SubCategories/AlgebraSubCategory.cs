class AlgebraSubCategory
{
    public static void Run()
    {
        Console.WriteLine("The subcatagories are are: \n \n");
        string[] SubCatagories = { };
        for (int i = SubCatagories.Length - 1; i >= 0; i--)
        {
            Console.WriteLine("** " + SubCatagories[i]);
        }
        Console.WriteLine("\n \n What subcatgory would you like?");
        string SubCategories = Console.ReadLine();
    }
}