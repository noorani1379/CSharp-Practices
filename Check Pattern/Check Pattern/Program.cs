
#region Functions

string[] Separate(string input)
{
    if (input.Contains(" "))
    {
        //split words of sentence by spaces
        return input.Split(' ');
    }
    else
    {
        //split word by characters
        string[] characters = new string[input.Length];
        for (int i = 0; i < input.Length; i++)
        {
            characters[i] = input[i].ToString();
        }
        return characters;
    }
}


List<char> FindPattern(string[] sentence)
  {
        //string[] words = pattern.Split(' ');

        List<char> result = new List<char>();

        for (int i = 0; i < sentence.Length - 1; i++)
        {
            if (sentence[i] == sentence[i + 1])
            {
                result.Add('1');
            }
            else
            {
                result.Add('0');
            }
        }
        return result;
  }

 bool IsPatternMatch<T>(List<T> list1, List<T> list2)
  {
        if (list1.Count != list2.Count)
        {
            return false;
        }

        for (int i = 0; i < list1.Count; i++)
        {
            if (!list1[i].Equals(list2[i]))
            {
                return false;
            }
        }

        return true;
  }

#endregion end Functions

//Inputs
Console.WriteLine("enter your string:");
string str=Console.ReadLine();

Console.WriteLine("enter your pattern:");
string ptr = Console.ReadLine();

/*
   string str = "dog cat cat dog";
   string ptr = "abba";
*/

string[] sentence_Result1 = Separate(str);
string[] sentence_Result2 = Separate(ptr);

List<char> pattern_Result1 = FindPattern(sentence_Result1);
List<char> pattern_Result2 = FindPattern(sentence_Result2);

bool compareResults = IsPatternMatch(pattern_Result1, pattern_Result2);

Console.WriteLine("Are same? " + compareResults);





     
