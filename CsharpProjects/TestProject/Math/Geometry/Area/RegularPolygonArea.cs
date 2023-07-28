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
    }
}