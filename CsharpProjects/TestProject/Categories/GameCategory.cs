class GameCategory {
    public static void Run()
    {
        Console.WriteLine("The subcategories are: \n \n");
        string[] SubCategories = {"Paper-and-pencil"};
        for (int i = SubCategories.Length - 1; i >= 0; i--)
        {
            Console.WriteLine("** " + SubCategories[i]);
        }
        Console.WriteLine("\n \n What subcatgory would you like?");
        string SubCategory = Console.ReadLine();
        if (SubCategory == "Paper-and-pencil") {
            PaperAndPencilGamesSubCategory.Run();
        }
    }
}