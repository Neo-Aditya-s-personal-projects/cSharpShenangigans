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
    }
}