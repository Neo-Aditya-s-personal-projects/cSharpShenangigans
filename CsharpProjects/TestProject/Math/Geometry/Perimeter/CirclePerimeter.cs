using System.Security.Cryptography.X509Certificates;

class CirclePerimeter
{
    public static void Run()
    {
        Console.WriteLine("Enter the radius:");
        double radius = Convert.ToDouble(Console.ReadLine());
        double circumference = 2 * Math.PI * radius;
        Console.WriteLine("The circumference/perimeter of the circle is " + circumference);
    }
}