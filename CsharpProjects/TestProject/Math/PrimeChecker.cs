class PrimeChecker
{
    public static void Run()
    {
        Console.WriteLine("Enter the number:");
        double number = Convert.ToInt32(Console.ReadLine());
        if (number == 1)
        {
            Console.WriteLine("Neither Prime nor Composite");
        }
        else
        {
            Boolean isComposite = false;
            double counter = 2;
            while ((counter < number) && (!isComposite))
            {
                if (number != counter)
                {
                    int tempInt = Convert.ToInt32(number / counter);
                    if (tempInt == number / counter)
                    {
                        isComposite = true;
                    }
                }
                counter++;
            }

            if (isComposite)
            {
                Console.WriteLine("The number is Composite");
            }
            else
            {
                Console.WriteLine("The number is Prime");
            }
        }
    }
}