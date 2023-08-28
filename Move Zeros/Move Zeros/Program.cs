int[] arr = { 0, 1, 0, 0,0,4,2,0, 3, 12,0 };
void MoveZeroes(int[] arr)
{
    //index of first zero of sortin natural numbers 
    int trackZero = 0;
    for (int i = 0; i < arr.Length; i++)
    {
        if (arr[i] == 0)
        {
            continue;
        }
        else
        {
            //swap
            (arr[i], arr[trackZero]) = (arr[trackZero], arr[i]);
            trackZero++;
        }
    }
}

MoveZeroes(arr);

foreach (int num in arr)
{
    Console.Write(num + " ");
}

