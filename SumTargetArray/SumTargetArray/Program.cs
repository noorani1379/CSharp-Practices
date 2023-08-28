int[] nums = { 0, 1, 2, 3, 4, 5, 6, 7, 8, 9, 10, 11, 12, 13, 14, 15 };//U can change sort & numbers
int target = 12;
for (int i = 0; i <= nums.Length; i++)
{
    for (int j = i + 1; j < nums.Length; j++)
    {
        if (target == nums[i] + nums[j]) Console.WriteLine($" {nums[i]} + {nums[j]} = {target}  index of  {i} , {j}");

    }
}