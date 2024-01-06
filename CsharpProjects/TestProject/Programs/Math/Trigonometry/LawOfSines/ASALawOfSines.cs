using System.Security.AccessControl;
using System.Security.Cryptography.X509Certificates;

class ASALawOfSines
{
    public static void Run()
    {
        Console.WriteLine("Enter Angle A(degrees):");
        double angleA = Convert.ToDouble(Console.ReadLine());
        Console.WriteLine("Enter Angle B(degrees):");
        double angleB = Convert.ToDouble(Console.ReadLine());
        Console.WriteLine("Enter side c:");
        double sideC = Convert.ToDouble(Console.ReadLine());
        Console.WriteLine("Angle A: " + angleA + " degrees");
        Console.WriteLine("Angle B: " + angleB + " degrees");
        double angleC = 180 - angleA - angleB;
        Console.WriteLine("Angle C: " + angleC + " degrees");
        double sideA = (sideC * Math.Sin(angleA))/Math.Sin(angleC);
        Console.WriteLine("Side a: " + sideA + " units");
        double sideB = (sideC * Math.Sin(angleB))/Math.Sin(angleC);
        Console.WriteLine("Side b: " + sideB + " units");
        Console.WriteLine("Side c: " + sideC + " units");
        double Area = sideA*sideB*Math.Sin(angleC);
        Console.WriteLine("Area: " + Area + " units squared");
        double Perimeter = sideA + sideB + sideC;
        Console.WriteLine("Perimeter: " + Perimeter + " units");
        Console.WriteLine("Do you want to find the values of another triangle? Y/N");
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