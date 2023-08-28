Console.WriteLine("Enter first word:");
string input1 = Console.ReadLine();

Console.WriteLine("Enter 2nd word:");
string input2 = Console.ReadLine();

List<char> charactersList1 = new();
List<char> charactersList2 = new();

//initializing list of separated characters
foreach (char c in input1)
{
    charactersList1.Add(c);
}
foreach (char c in input2)
{
    charactersList2.Add(c);
}

//ordering then comparing
bool isAnagram = charactersList1
                     .OrderBy(item => item)
                     .SequenceEqual(charactersList2
                                    .OrderBy(item => item));
                                
if (isAnagram)
{
    Console.WriteLine("Anagram");
}
else
{
    Console.WriteLine("not Anagram");
}

