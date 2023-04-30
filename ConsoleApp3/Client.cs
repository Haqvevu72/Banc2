using ConsoleApp3;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp3
{
    internal class client
    {
        // => Fileds of `client` class
        public Guid ID { get; set; }
        public string? Name { get; set; }
        public string? Surname { get; set; }
        public bankcard? bankaccount { get; set; }

        // => Constructor for `client` class
        public client(Guid iD, string? name, string? surname, bankcard? bankaccount)
        {
            ID = iD;
            Name = name;
            Surname = surname;
            this.bankaccount = bankaccount;
        }

        // => Overriding ToString() method 
        public override string ToString()
        {
            return $"ID: {ID}\nName: {Name}\nSurname: {Surname}\n{bankaccount}";
        }


    }
}
