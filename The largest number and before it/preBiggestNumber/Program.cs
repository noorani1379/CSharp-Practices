int[] numbers = { 30, 50, 80, 20, 10, 70, 40, 60 };

int max = numbers[0];
int preMax= numbers[1];

foreach (int number in numbers)
{
    if (max < number) max = number;

    else if (preMax < number) preMax = number;
}

Console.WriteLine($"{max}, {preMax}");