class TrapezoidArea
{
    public static void Run()
    {
        Console.WriteLine("Enter the first base:");
        double base1 = Convert.ToDouble(Console.ReadLine());
        Console.WriteLine("Enter the second base:");
        double base2 = Convert.ToDouble(Console.ReadLine());
        Console.WriteLine("Enter the height:");
        double height = Convert.ToDouble(Console.ReadLine());
        double area = (base1 + base2) / 2;
        area *= height;
        Console.WriteLine("The area of the trapezoid is" + area);
    }
}