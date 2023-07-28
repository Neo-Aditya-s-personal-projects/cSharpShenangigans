class RegularPolygonPerimeter {
    public static void Run() {
        Console.WriteLine("Enter the amount of sides:");
        int numberOfSides = Convert.ToInt32(Console.ReadLine());
        Console.WriteLine("Enter the length of each side:");
        double length = Convert.ToDouble(Console.ReadLine());
        double perimeter = length * numberOfSides;
        Console.WriteLine("The perimeter of the polygon is " + perimeter);
    }
}