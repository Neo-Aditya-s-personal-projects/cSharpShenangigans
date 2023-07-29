class GeometrySubCategory
{
    public static void Run()
    {
        Console.WriteLine("The subcategories are are: \n \n");
        string[] SubCategories = { "Area", "Perimeter" };
        for (int i = SubCategories.Length - 1; i >= 0; i--)
        {
            Console.WriteLine("** " + SubCategories[i]);
        }
        Console.WriteLine("\n \n What subcatgory would you like?");
        string SubCategory = Console.ReadLine();
        if (SubCategory == "Area")
        {
           AreaSubCategory.Run(); 
        }
        else if (SubCategory == "Perimeter") 
        {
            PerimeterSubCategory.Run();
        }
        else {
            Console.WriteLine("Try Again");
            Run();
        }
    }
}