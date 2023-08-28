Console.WriteLine("enter number:");
int input =Convert.ToInt32( Console.ReadLine());


Console.WriteLine(AddDigits(input));

int AddDigits(int num)
{
    int sum = 0;

    //Separation of numbers
    while (num >= 1)
    {
        sum += num % 10;
        num /= 10;
    }

    if (sum < 10)
    {
        //The main result we expect
        return sum;
    }

    //If the sum is 10 or more, call the function again to repeat
    return AddDigits(sum);
}
