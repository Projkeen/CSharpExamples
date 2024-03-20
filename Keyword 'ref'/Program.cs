// See https://aka.ms/new-console-template for more information
//Console.WriteLine("Hello, World!");

static int NewValue(int value) // <- Copied variable from Main method
{
    return value++;
} //after executing method, the value is deleted

static int NewValueViaRef(ref int value)
{
    return value += 2;
}

static int NewSize(Box box) // <- Copied entity from Main method
{
    box.Size = 25;
    return box.Size;
}
static int NewSizeViaRef(ref Box box)
{
    return box.Size = 25;    
}

static int NewArray(int[] array)
{
    return array[0] = 10;
}

static string NewType(Table newtable)
{
    //newtable = new Table();
    newtable.Type = "Kitchen";
    return newtable.Type;
}

static string NewTypeViaRef(ref Table newtable)
{
   return newtable.Type = "Living room";
}

static void NewTypeViaRef2(ref Table newtable)
{
    newtable = new Table();
}

int mainNumber = 5; // value type
NewValue(mainNumber);
Console.WriteLine($"Value type in args method 'NewValue', result: {mainNumber}, no changes.");
NewValueViaRef(ref mainNumber);
Console.WriteLine($"Value type in args method 'NewValueViaRef' via keyword 'ref', result: {mainNumber}.");
Box box = new Box(); // value type
box.Size = 20;
NewSize(box);
Console.WriteLine($"Value type in args method 'NewSize', result: {box.Size}, no changes.");
int size = NewSizeViaRef(ref box);
Console.WriteLine($"Value type in args method 'NewSizeViaRef' via keyword 'ref', result: {size}.");
Console.WriteLine("_________Reference type__________");
int[] array = { 19, 17, 14 }; // reference type
Console.WriteLine($"First element from array: {array[0]}.");
NewArray(array);
Console.WriteLine($"First element from array after method 'NewArray': {array[0]}.");
Table table = new Table(); // reference type
table.Type = "Workbench";
Console.WriteLine($"Type of table before method 'NewType', result: {table.Type}");
NewType(table);
Console.WriteLine($"Type of table after method 'NewType', result: {table.Type}");
NewTypeViaRef(ref table);
Console.WriteLine($"Type of table after method 'NewTypeViaRef', result: {table.Type}");
NewTypeViaRef2(ref table);
Console.WriteLine($"Type of table after method 'NewTypeViaRef2', result: {table.Type}");

struct Box
{
    public int Size;
}

class Table
{
    public string Type;
}
