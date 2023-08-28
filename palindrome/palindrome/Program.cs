Console.Write("enter string ");
string input = Console.ReadLine();

int length = input.Length;
string reversed = "";

for (int i = length - 1; i >= 0; i--) reversed += input[i];

if (input == reversed) Console.WriteLine(" that's palindrome");
else Console.WriteLine("not pali");