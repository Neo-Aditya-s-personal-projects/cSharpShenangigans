// See https://aka.ms/new-console-template for more information
Console.WriteLine("Enter a number");
int input = Convert.ToInt32(Console.ReadLine());
int reverse = 0;
int temp = input;
int digit;
if (input < 0) {
    Console.WriteLine("This number is not a Palindrome");
} 
else {
    while (temp !=0) {
        digit = temp % 10;
        reverse = reverse * 10 + digit;
        temp /= 10;
    }
    if (reverse == input) {
        Console.WriteLine("This number is a Palindrome");
    }
    else {
        Console.WriteLine("This number isn't a Palindrome");
    }
}