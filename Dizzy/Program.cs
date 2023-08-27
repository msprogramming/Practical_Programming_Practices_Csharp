// See https://aka.ms/new-console-template for more information
Console.WriteLine("///Inputs");
string inputs = "T4 l16 _36 510 _27 s26 _11 320 414 {6 }39 C2 T0 m28 317 y35 d31 F1 m22 g19 d38 z34 423 l15 329 c12 ;37 19 h13 _30 F5 t7 C3 325 z33 _21 h8 n18 132 k24";


Console.WriteLine("///Process Data");
var subInputs = inputs.Split(' ');
var outputs = new string[subInputs.Length];

foreach (var subInput in subInputs)
{
    string charachter = subInput.Substring(0, 1);
    int index = int.Parse(subInput.Substring(1, subInput.Length - 1));
    outputs[index] = charachter;
}

Console.WriteLine("///Output");
for (int i = 0; i < outputs.Length; i++)
{
    Console.Write(outputs[i]);
}
Console.WriteLine();
Console.WriteLine("///msprogramming.ir");
