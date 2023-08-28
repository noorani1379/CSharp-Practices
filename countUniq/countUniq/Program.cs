int[] nums = { 0, 0, 1, 1, 1, 2, 2, 3, 3, 4, 5, 6, 6, 7 };

int count = 1, i = count;


while (i < nums.Length)
{

    if (nums[i] != nums[i - 1])
    {
        count++;
    }

    i++;
}

Console.WriteLine(count);