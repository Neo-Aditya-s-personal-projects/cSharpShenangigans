using System.ComponentModel.DataAnnotations;

class AreaSubCategory
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
            CircleArea.Run();
        }
        else if (Program == "Triangle")
        {
            TriangleArea.Run();
        }
        else if (Program == "Parallelogram")
        {
            Parallelogram.Run();
        }
        else if (Program == "Trapezoid")
        {
            TrapezoidArea.Run();
        }
        else if (Program == "Regular Polygon")
        {
            RegularPolygonArea.Run();
        }
        else {
            Console.WriteLine("Try Again");
            AreaSubCategory.Run();
        }
    }
}