using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Anket2
{
    public class Person
    {
        public string Name { get; set; }
        public string Surname { get; set; }
        public string Email { get; set; }

        public string Phone { get; set; }

        public DateTime Date { get; set; }

        public Person() { }

        public Person(string name, string surname, string email, string phone, DateTime date)
        {
            Name = name;
            Surname = surname;
            Email = email;
            Phone = phone;
            Date = date;
        }

        public override string ToString()
        {
            return Name;
        }
    }
}
