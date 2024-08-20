// See https://aka.ms/new-console-template for more information
using RecruitmentApp;
using System.Threading.Channels;
//Console.WriteLine("Hello, World!");
while (true)
{
    List<Record> records = new List<Record>();

    Record softWareEngineer = new Record(1, "Software Engineer", "Middle", "Created");
    Record frontEndEngineer = new Record(2, "Frontend Engineer", "Senior", "Created");
    Record projectManager = new Record(3, "Project Manager", "Trainee", "Created");
    Record AQA = new Record(4, "AQA", "Junior", "Created");
    records.Add(softWareEngineer);
    records.Add(frontEndEngineer);
    records.Add(projectManager);
    records.Add(AQA);
    Service service = new Service();
    
    Console.WriteLine("Hello!");
    while (true)
    {
        Console.WriteLine("Vacancy list:");
        foreach (var record in records)
        {
            record.ViewRecord(record);            
        }
        Console.WriteLine("Status:");
        foreach (var record in records)
        {
            service.ShowStatus(record);
        }

        Console.WriteLine("Select operation");
        Console.WriteLine("1. Sent to review");
        Console.WriteLine("2. Aprove");
        Console.WriteLine("3. Reject");
        Console.WriteLine("4. Exit");
        Console.WriteLine("_____________________________________________________");

        var input = Console.ReadLine();
        try
        {
            switch (input)
            {
                case "1":
                    Console.WriteLine("Enter vacancy id for sending to review");
                    var idToSubmitForApproval = Convert.ToInt32(Console.ReadLine());
                    foreach (var record in records)
                    {
                        if (idToSubmitForApproval == record.Id)
                        {
                            service.SubmitForApproval(record);
                            service.ShowStatus(record);
                        }
                    }
                    break;
                case "2":
                    Console.WriteLine("Enter vacancy id for approving");
                    var idToApprove = Convert.ToInt32(Console.ReadLine());
                    foreach (var record in records)
                    {
                        if (idToApprove == record.Id)
                        {
                            service.Approve(record);
                            service.ShowStatus(record);
                        }
                    }
                    break;
                case "3":
                    Console.WriteLine("Enter vacancy id for rejecting");
                    var idToReject = Convert.ToInt32(Console.ReadLine());
                    foreach (var record in records)
                    {
                        if (idToReject == record.Id)
                        {
                            service.Reject(record);
                            service.ShowStatus(record);
                        }
                    }
                    break;
                case "4":
                    Console.WriteLine("Good luck");
                    return;
                default:
                    Console.WriteLine("Unknown command");
                    break;
            }
        }
        catch (Exception ex)
        {
            Console.WriteLine($"Error: {ex.Message}");

        }


    }
}




