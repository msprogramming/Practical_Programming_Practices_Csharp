// See https://aka.ms/new-console-template for more information
Console.WriteLine("///Input");
string inputs = "Whiskey Hotel Four Tango Dash Alpha Romeo Three Dash Yankee Oscar Uniform Dash Sierra One November Kilo India November Golf Dash Four Bravo Zero Uniform Seven";

Console.WriteLine("///Proccess Data");
var subInputs = inputs.Split(' ');
var output = new string[subInputs.Length];

var numbers = new Dictionary<string, string>();
numbers.Add("Dash", "-");
numbers.Add("One", "1");
numbers.Add("Two", "2");
numbers.Add("Three", "3");
numbers.Add("Four", "4");
numbers.Add("Five", "5");
numbers.Add("Six", "6");
numbers.Add("Seven", "7");
numbers.Add("Eight", "8");
numbers.Add("Nine", "9");

for (int i = 0; i < subInputs.Length; i++)
{
    if (numbers.ContainsKey(subInputs[i]))
    {
        output[i] = numbers[subInputs[i]];
    }
    else
    {
        output[i] = subInputs[i].Substring(0, 1);
    }
}

Console.WriteLine("///Outputs");
for (int i = 0; i < output.Length; i++)
{
    Console.Write(output[i]);
}

Console.WriteLine();
Console.WriteLine();
Console.WriteLine("///msprogramming.ir");
