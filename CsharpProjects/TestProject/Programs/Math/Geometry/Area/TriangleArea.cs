class TriangleArea
{
    public static void Run()
    {
        Console.WriteLine("Enter the base:");
        double baseOfTriangle = Convert.ToDouble(Console.ReadLine());
        Console.WriteLine("Enter the height:");
        double height = Convert.ToDouble(Console.ReadLine());
        double area = (baseOfTriangle * height) / 2;
        Console.WriteLine("The area og the triangle is " + area);
        Console.WriteLine("Do you want to find the area of another triangle? Y/N");
        string repeat = Console.ReadLine();
        while (repeat != "Y" && repeat != "N")
        {
            Console.WriteLine("Please enter either a capital Y or a capital N");
            repeat = Console.ReadLine();
        }
        if (repeat == "Y") {
            Run();
        }
    }
}