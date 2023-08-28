
Console.WriteLine("Hello user, plz enter number of sequence:");
int numberOfSeries = Convert.ToInt32(Console.ReadLine());

if (numberOfSeries > 2)
{
    int preSum = 1, sum = preSum;
    Console.Write("1 1");
    for (int i = 1; i <= numberOfSeries - 2; i++)
    {
        sum += preSum;
        preSum = sum - preSum;
        Console.Write($" {sum}");
    }
    //Console.WriteLine(preSum, sum);
}
else if (numberOfSeries == 2) Console.WriteLine("1 1");
else Console.WriteLine("1");