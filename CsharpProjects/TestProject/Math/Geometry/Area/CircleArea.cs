class CircleArea
{
    public static void Run()
    {
        Console.WriteLine("Enter the radius:");
        double radius = Convert.ToDouble(Console.ReadLine()); ;
        double area = radius * Math.PI;
        Console.WriteLine("The area of the circle is " + area);
    }
}