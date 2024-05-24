using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Properties
{
    class Human
    {
        private string _name;
        public void SetName(string n)
        {
            if (n.Length >= 2)
                //Console.WriteLine("name too short!");
                _name = n;
            else _name = "incorrect name";
        }

        public string GetName()
        {
            //Console.WriteLine(_name);
            return _name;
        }

        private int _age;
        public int Age
        {
            get { return _age; }
            set
            {
                if (value > 0) 
                //Console.WriteLine("error!");
                _age = value;
            }
        }

        public void ShowInfo()
        {  
            if (_age > 0 && _name.Length >= 2)
                Console.WriteLine($"Your name is: {_name}, Age: {_age} years old");
            else Console.WriteLine("Name to short or incorrect age!!!");
        }

        //public Human(string name, int age)
        //{
        //    Name= name;
        //    Age = age;
        //}

        //public Human() 
        //{

        //}
    }
}
