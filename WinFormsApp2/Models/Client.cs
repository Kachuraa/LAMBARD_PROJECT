using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WinFormsApp2.Models
{
    public class Client
    {
        public string Name { get; }
        public string Surname { get; }
        public string ContactInfo { get; }

        public Client(string name, string surname, string contactInfo)
        {
            Name = name;
            Surname = surname;
            ContactInfo = contactInfo;
        }

        public override string ToString()
        {
            return $"{Name} {Surname} ({ContactInfo})";
        }
    }
}