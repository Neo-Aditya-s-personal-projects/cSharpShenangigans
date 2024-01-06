using System.Security.AccessControl;
using System.Security.Cryptography.X509Certificates;

class SSSLawOfCosines
{
    public static void Run()
    {
        Console.WriteLine("Enter side a(degrees):");
        double sideA = Convert.ToDouble(Console.ReadLine());
        Console.WriteLine("Enter Angle B(degrees):");
        double angleB = Convert.ToDouble(Console.ReadLine());
        Console.WriteLine("Enter side a:");
        double sideA = Convert.ToDouble(Console.ReadLine());
        Console.WriteLine("Angle A: " + angleA + " degrees");
        Console.WriteLine("Angle B: " + angleB + " degrees");
        double angleC = 180 - angleA - angleB;
        Console.WriteLine("Angle C: " + angleC + " degrees");
        Console.WriteLine("Side a: " + sideA + " units");
        double sideB = (sideA * Math.Sin(angleB))/Math.Sin(angleA);
        Console.WriteLine("Side b: " + sideB + " units");
        double sideC = (sideA * Math.Sin(angleC))/Math.Sin(angleA);
        Console.WriteLine("Side c: " + sideC + " units");
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