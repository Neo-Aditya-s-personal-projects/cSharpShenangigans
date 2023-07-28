class Parallelogram
{
    public static void Run()
    {
        Console.WriteLine("Enter the base:");
        double baseofParallelogram = Convert.ToDouble(Console.ReadLine());
        Console.WriteLine("Enter the height:");
        double height = Convert.ToDouble(Console.ReadLine());
        double area = baseofParallelogram * height;
        Console.WriteLine("The area of the parallelogram is " + area);
    }
}