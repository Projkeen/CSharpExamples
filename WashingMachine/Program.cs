// See https://aka.ms/new-console-template for more information
using System.Reflection.Metadata.Ecma335;
using System.Threading.Channels;
using System.Xml.Schema;
using WashingMachine;

Machine washingMachine = new Machine();
Console.WriteLine("Через какое время начать стирку? 0 - без отложенной стирки");
try
{    
    washingMachine.TimeBeforeStart = Convert.ToInt32(Console.ReadLine());
}
catch(Exception)
{
    Console.WriteLine("Введите время в минутах!");    
}

Console.WriteLine("Выберите режим стирки: <Simple mode>, <Fast MOde>");
try
{
    string mode = Console.ReadLine();
    if (mode.ToLower()=="simple mode")
    {
        washingMachine.SimpleMode();
    }
    else if (mode.ToLower()=="fast mode")
    {
        washingMachine.FastMode();
    }
    else
    {
        Console.WriteLine("unknown mode");
    }
}
catch(Exception)
{
    Console.WriteLine("Введите режим!");
}