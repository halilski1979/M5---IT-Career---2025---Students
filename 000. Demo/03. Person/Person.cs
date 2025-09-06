using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _03._Person
{
    public class Person
    {
        
        //Auto propertie
        public string Name { get;private set; }
        public int Age { get; private set; }
        public double Salary { get;private set; }

        public Person(string name, int age, double salary)
        {
            Name = name;
            Age = age;
            Salary = salary;
        }


        public override string ToString()
        {
          return $"{this.Name},{this.Age} godini, Zaplata: {this.Salary}";
        }

    }
}
