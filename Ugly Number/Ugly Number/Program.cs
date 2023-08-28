Console.WriteLine("enter number to check is ugly");
Console.WriteLine(IsUgly(Convert.ToInt32(Console.ReadLine())));
bool IsUgly(int num)
{
    int[] primes = { 2, 3, 5 };

    foreach (int prime in primes)
    {
        while (num % prime == 0)
        {
            num /= prime;
        }
    }

    return num == 1;
}
