class MathCategory
{
    public static void Run()
    {
        Console.WriteLine("The subcategories are: \n \n");
        string[] SubCategories = { "Algebra", "Calculus", "Checker", "Geometry" };
        for (int i = SubCategories.Length - 1; i >= 0; i--)
        {
            Console.WriteLine("** " + SubCategories[i]);
        }
        Console.WriteLine("\n \n What subcatgory would you like?");
        string SubCategory = Console.ReadLine();
        if (SubCategory == "Algebra") {
            AlgebraSubCategory.Run();
        }
        else if (SubCategory == "Calculus") {
            AlgebraSubCategory.Run();
        }
        else if (SubCategory == "Checker") {
            CheckerSubCategory.Run();
        }
        else if (SubCategory == "Geometry") {
            GeometrySubCategory.Run();
        }
        else {
            Console.WriteLine("Try Again");
            Run();
        }
    }
}