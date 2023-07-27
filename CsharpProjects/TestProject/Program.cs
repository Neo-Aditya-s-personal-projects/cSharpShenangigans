// See https://aka.ms/new-console-template for more information
Console.WriteLine("Enter the number:");
int number = Convert.ToInt32(Console.ReadLine());
Boolean isPrime = true;
double counter = 2;
while (counter < number) {
    if (number != counter) {
        int tempInt = Convert.ToInt32(number/counter);
        if (!(tempInt == number/counter)) {
            isPrime = false;
        }
    }
}

if (isPrime) {
    Console.WriteLine("The number is Prime");
}
else {
    Console.WriteLine("The number isn't Prime");
}