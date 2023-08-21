class RegularPolygonArea
{
    public static void Run()
    {
        Console.WriteLine("Enter the amount of sides:");
        int numberOfSides = Convert.ToInt32(Console.ReadLine());
        Console.WriteLine("Enter the length of each side:");
        double length = Convert.ToDouble(Console.ReadLine());
        double perimeter = length * numberOfSides;
        double apothem = length / 2;
        apothem /= Math.Tan(Math.PI / numberOfSides);
        double area = apothem * perimeter;
        area /= 2;
        Console.WriteLine("The area of the regular polygon is " + area);
        Console.WriteLine("Do you want to find the area of another regular polygon? Y/N");
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