// See https://aka.ms/new-console-template for more information
using System.Runtime.CompilerServices;

Console.WriteLine("///Input");
Console.WriteLine("///Process Data");
///100 - 999
///condition : 2digit !0
///
int counter = 0;
for (int i = 100; i < 1000; i++)
{
    var result = Has_Condition(i);
    if (result)
    {
        counter++;
        //Console.WriteLine(i);
    }
}
Console.WriteLine("///output");
Console.WriteLine("count:"+ counter);
Console.WriteLine();
Console.WriteLine("///msprogramming.ir");

bool Has_Condition(int inputNumber)
{
    HashSet<int> set = new HashSet<int>();
    var number = inputNumber;
    var digit = 0;
    for (int i = 0; i < 3; i++)
    {
        digit = number % 10;
        set.Add(digit);
        number = number / 10;
        //Console.WriteLine(digit);
    }
    if (set.Count == 2 && !set.Contains(0))
    {
        return true;
    }
    return false;
}


