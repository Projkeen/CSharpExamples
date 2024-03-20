// See https://aka.ms/new-console-template for more information
//Console.WriteLine("Hello, World!");
using System.Text;

string SimpleString()
{
    string str = "Hello";
    str += " C#";
    str += " &";
    str += " .NET";
    str += " World";
    return str;
}

string ViaStringBuilder()
{
    StringBuilder sb = new StringBuilder("Hello");
    sb.Append(" C#");
    sb.Append(" &");
    sb.Append(" .NET");
    return sb.ToString();
}

string StringViaForLoop()
{
    string str = string.Empty;
    for (int i = 1; i <= 10; i++)
    {
        str += i.ToString() + " ";
    }
    return str;
}

//string SimpleString2()
//{
//    string str = "Hello";
//    str = str + " C#";
//    return str;
//}

string s = SimpleString();
Console.WriteLine(s);
Console.WriteLine(ViaStringBuilder());
Console.WriteLine(StringViaForLoop());