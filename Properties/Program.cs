// See https://aka.ms/new-console-template for more information


using Properties;

Human human = new Human();
//{
//    Name = "AL",
//    Age = 32
//};
Console.WriteLine("What is your name?");
string n = Console.ReadLine();
human.SetName(n);
Console.WriteLine("How old are you?");
human.Age = Convert.ToInt32(Console.ReadLine());
human.ShowInfo();

//Random random = new Random();
//double v = random.Next(8,16);
//Console.WriteLine(v);


