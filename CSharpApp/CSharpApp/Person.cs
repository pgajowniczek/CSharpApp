using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CSharpApp
{
    public abstract class Person
    {
        protected string Name { get; private set; }
        protected string Surname { get; private set; }
        public string Sex { get; private set; }

        public Person(string name, string surname, string sex)
        {
            this.Name = name;
            this.Surname = surname;
            this.Sex= sex;
        }

    }
}
