class TriangleArea
{
    public static void Run()
    {
        Console.WriteLine("Enter the base:");
        double baseOfTriangle = Convert.ToDouble(Console.ReadLine());
        Console.WriteLine("Enter the height:");
        double height = Convert.ToDouble(Console.ReadLine());
        double area = (baseOfTriangle * height) / 2;
        Console.WriteLine("The area og the triangle is " + area);
    }
}