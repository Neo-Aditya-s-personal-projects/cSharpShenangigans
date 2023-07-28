using System.ComponentModel.DataAnnotations;

class PerimeterSubCategory
{
    public static void Run()
    {
        Console.WriteLine("The options are: \n \n");
        string[] Programs = { "Circle", "Triangle", "Parallelogram", "Trapezoid", "Regular Polygon" };
        for (int i = Programs.Length - 1; i >= 0; i--)
        {
            Console.WriteLine("** " + Programs[i]);
        }
        Console.WriteLine("Which option do you choose?");
        string Program = Console.ReadLine();
        if (Program == "Circle")
        {
            CirclePerimeter.Run();
        }
        else if (Program == "Triangle")
        {
            TrianglePerimeter.Run();
        }
        else if (Program == "Parallelogram")
        {
            ParallelogramPerimeter.Run();
        }
        else if (Program == "Regular Polygon")
        {
            RegularPolygonPerimeter.Run();
        }
        else {
            Console.WriteLine("Try Again");
            Run();
        }
    }
}