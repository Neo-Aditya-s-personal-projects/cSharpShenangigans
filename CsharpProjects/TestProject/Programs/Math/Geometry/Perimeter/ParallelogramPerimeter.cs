class ParallelogramPerimeter
{
    public static void Run()
    {
        Console.WriteLine("Enter the length:");
        double length = Convert.ToDouble(Console.ReadLine());
        Console.WriteLine("Enmter the width:");
        double width = Convert.ToDouble(Console.ReadLine());
        double perimeter = length + width;
        perimeter *= 2;
        Console.WriteLine("The perimeter of the parallelogram is " + perimeter);
        Console.WriteLine("Do you want to find the perimeter of another paralellogram? Y/N");
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