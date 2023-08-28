Console.WriteLine("Enter your number:");

int number = int.Parse(Console.ReadLine());
string reversedNumber = "";

while (number > 0)
{
    reversedNumber += (number % 10).ToString();
    number /= 10;
}
Console.WriteLine($"result: {reversedNumber}");

