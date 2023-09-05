using System.Security.Cryptography.X509Certificates;

class CirclePerimeter
{
    public static void Run()
    {
        Console.WriteLine("Enter the radius:");
        double radius = Convert.ToDouble(Console.ReadLine());
        double circumference = 2 * Math.PI * radius;
        Console.WriteLine("The circumference/perimeter of the circle is " + circumference);
        Console.WriteLine("Do you want to find the perimeter of another circle? Y/N");
        string repeat = Console.ReadLine();
        while (repeat != "Y" && repeat != "N")
        {
            Console.WriteLine("Please enter either a capital Y or a capital N");
            repeat = Console.ReadLine();
        }
        if (repeat == "Y") {
            Run();
        }
    }
}