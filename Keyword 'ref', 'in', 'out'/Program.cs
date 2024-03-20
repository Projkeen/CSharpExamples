// See https://aka.ms/new-console-template for more information
//Console.WriteLine("Hello, World!");
static void NewValueViaRef(ref int newValue)
{
    newValue = 2;
}
static void NewValueViaOut (out int newValue)
{
    newValue = 3; // need initialize variable!!! if using "out"
}

static void ReadValue(in int r)
{
    // r = 3; //error! value cannot be changed, only read.
    Console.WriteLine($"Value after method with 'in' parameter, result: {r}");
}

int valueforRef = 1; //value type
int valueforOut; // it is not necessary to initialize the variable for keyword "out"
NewValueViaRef(ref valueforRef);
Console.WriteLine($"Value via 'ref', result: {valueforRef}.");
NewValueViaOut(out valueforOut); 
Console.WriteLine($"Value via 'out', result: {valueforOut}.");
Console.WriteLine("______________________");
string s = "21";
int.TryParse(s, out int result); // from s, to result
Console.WriteLine($"Change string to int, {result}");
int valueForIn = 1;
//Console.WriteLine(valueForIn);
ReadValue(valueForIn);
