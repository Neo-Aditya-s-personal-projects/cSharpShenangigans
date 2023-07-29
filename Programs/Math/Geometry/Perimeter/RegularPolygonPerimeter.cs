class RegularPolygonPerimeter {
    public static void Run() {
        Console.WriteLine("Enter the amount of sides:");
        int numberOfSides = Convert.ToInt32(Console.ReadLine());
        Console.WriteLine("Enter the length of each side:");
        double length = Convert.ToDouble(Console.ReadLine());
        double perimeter = length * numberOfSides;
        Console.WriteLine("The perimeter of the polygon is " + perimeter);
        Console.WriteLine("Do you want to find the perimeter of another regular polygon? Y/N");
        char repeat = Console.ReadLine();
        while (repeat != 'Y' && repeat != 'N')
        {
            Console.WriteLine("Please enter either a capital Y or a capital N");
            repeat = Console.ReadLine();
        }
        if (repeat == 'Y') [
            Run();
        ]
    }
}