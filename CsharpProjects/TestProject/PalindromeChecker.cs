class PalindromeChecker
{
    public static void Run()
    {
        // See https://aka.ms/new-console-template for more information
        Console.WriteLine("Enter a number");
        int input = Convert.ToInt32(Console.ReadLine());
        int reverse = 0;
        int temp = input;
        int place = 1;
        if (input < 0)
        {
            Console.WriteLine("This number is not a Palindrome");
        }
        else
        {
            while (temp != 0)
            {
                int digit = input % 10;
                reverse = reverse * place + digit;
                place = place * 10;
                temp = temp / 10;
            }
            if (reverse == input)
            {
                Console.WriteLine("This number is a Palindrome");
            }
            else
            {
                Console.WriteLine("This number isn't a Palindrome");
            }
        }
    }
}