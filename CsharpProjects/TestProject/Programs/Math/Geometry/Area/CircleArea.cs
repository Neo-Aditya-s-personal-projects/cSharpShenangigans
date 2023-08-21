class CircleArea
{
    public static void Run()
    {
        Console.WriteLine("Enter the radius:");
        double radius = Convert.ToDouble(Console.ReadLine()); ;
        double area = radius * Math.PI;
        Console.WriteLine("The area of the circle is " + area);
        Console.WriteLine("Do you want to find the area of another circle? Y/N");
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