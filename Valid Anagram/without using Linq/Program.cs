Console.WriteLine("Enter firsttt word:");
string input1 = Console.ReadLine();

Console.WriteLine("Enter 2nd word:");
string input2 = Console.ReadLine();

List<char> charactersList1 = new();
List<char> charactersList2 = new();

//initializing
foreach (char c in input1)
{
    charactersList1.Add(c);
}
foreach (char c in input2)
{
    charactersList2.Add(c);
}



if (charactersList1.Count == charactersList2.Count)
{
    //values are the same and unordered, they match
    for (int i = 0; i < charactersList1.Count; i++)
    {
        charactersList2.Remove(charactersList1[i]);
    }

    Console.WriteLine(charactersList2.Count == 0 ? "Anagram" : "not Anagram");

}
else
{
    Console.WriteLine("not Anagram");
}