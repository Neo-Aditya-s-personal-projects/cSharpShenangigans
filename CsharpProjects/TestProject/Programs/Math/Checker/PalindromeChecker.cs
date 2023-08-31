class PalindromeChecker
{
    public static void Run()
    {
        // See https://aka.ms/new-console-template for more information
        Console.WriteLine("Enter your word/number");
        string stringInput = Console.ReadLine();
        char[] input = stringInput.ToCharArray();
        Boolean isAPalindrome = true;
        for (int i = input.Length - 1; i >= 0; i--) {
            if (input[i] != input[input.Length - i - 1]) {
                isAPalindrome = false;
            }
        }
        if (isAPalindrome)
            Console.WriteLine("The word/number is a palindrome");
        else
            Console.WriteLine("The word/number isn't a palindrome");
        Console.WriteLine("Do you want to check another word/number? Y/N");
        char repeat = Convert.ToChar(Console.ReadLine());
        while (repeat != 'Y' && repeat != 'N' && repeat!='y' && repeat!='n')
        {
            Console.WriteLine("Please enter either a Y or an N");
            repeat = Convert.ToChar(Console.ReadLine());
        }
        if (repeat == 'Y' || repeat =='y')
            Run();
    }
}