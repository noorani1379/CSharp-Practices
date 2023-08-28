int[] numbers = { 1, 2, 3, 4, 5, 5 };

for (int i = 0; i < numbers.Length; i++)
{
    for (int j = i + 1; j < numbers.Length; j++)
    {

        if (numbers[i] == numbers[j])
        {

            Console.WriteLine("Repetition");
            break;
        

        }
       
    }
}
