int firstNumber = 0;
int secondNumber = 0;
string operatorSymbol = "";


Console.WriteLine("Enter the first number: ");
firstNumber = Convert.ToInt32(Console.ReadLine());


Console.WriteLine("Enter the second number: ");
secondNumber = Convert.ToInt32(Console.ReadLine());


Console.WriteLine("Enter the operator: ");
operatorSymbol = Console.ReadLine();


int result = 0;
switch (operatorSymbol)
{
    case "+":
        result = firstNumber + secondNumber;
        break;
    case "-":
        result = firstNumber - secondNumber;
        break;
    case "*":
        result = firstNumber * secondNumber;
        break;
    case "/":
        result = firstNumber / secondNumber;
        break;
}

Console.WriteLine(result);

