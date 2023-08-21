class ParallelogramArea
{
    public static void Run()
    {
        Console.WriteLine("Enter the base:");
        double baseofParallelogram = Convert.ToDouble(Console.ReadLine());
        Console.WriteLine("Enter the height:");
        double height = Convert.ToDouble(Console.ReadLine());
        double area = baseofParallelogram * height;
        Console.WriteLine("The area of the parallelogram is " + area);
        Console.WriteLine("Do you want to find the area of another parallelogram? Y/N");
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