using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RecruitmentApp
{
    public class Record
    {
        public int Id { get; private set; }
        public string Type { get; private set; }
        public string Name { get; private set; }
        private string status;
        public string Status
        {
            get { return status; }
            set { status = value; }
        }

        public Record(int id, string name, string type, string status)
        {
            Id = id;
            Name = name;
            Type = type;
            Status = status;
        }
        public void ViewRecord(Record record)
        {
            switch (Type)
            {
                case "Middle":
                    Console.WriteLine($"Vacancy: Id - {Id}. {Name},Type: {Type}, Status: {Status}");
                    break;                
                case "Senior":
                    Console.WriteLine($"Vacancy: Id - {Id}. {Name},Type: {Type}, Status: {Status}");
                    break;                
                case "Trainee":
                    Console.WriteLine($"Vacancy: Id - {Id}. {Name},Type: {Type}, Status: {Status}");
                    break;                
                case "Junior":
                    Console.WriteLine($"Vacancy: Id - {Id}. {Name},Type: {Type}, Status: {Status}");
                    break;
                default:
                    Console.WriteLine($"Unknown {Id}. {Name},Type: {Type}, Status: {Status}");
                    break;
            }
        }
    }

    public class Service
    {

        public void SubmitForApproval(Record record)
        {
            record.Status = "Sent for review";
        }

        public void Approve(Record record)
        {
            if (record.Status == "Sent for review")
            {
                record.Status = "Approved";
            }
            throw new InvalidOperationException("You cannot approve record that has not been sending for review");
        }

        public void Reject(Record record)
        {
            if (record.Status == "Sent for review")
            {
                record.Status = "Rejected";
            }
            throw new InvalidOperationException("You cannot reject record that has not been sending for review");
        }

        public void ShowStatus(Record record)
        {
            Console.WriteLine($"Vacancy {record.Name} - {record.Status}");
        }
    }
}
