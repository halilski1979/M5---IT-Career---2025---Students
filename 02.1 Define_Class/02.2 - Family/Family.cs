using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _02._2___Family
{
    public class Family
    {
        private List<Person> family=new List<Person>();

        public void AddMember(string name, int age)
        {
           //family.Add(new Person(name, age));
            
            Person p=new Person(name,age);
            family.Add(p);
        }

        public void SortNameLessThan30()
        {
            family=family.Where(x=>x.Age>30 ).OrderBy(x=>x.Name).ToList();

            foreach (Person p in family)
            {
                Console.WriteLine($"{p.Name} {p.Age}");
            }
        }

        public void Print()
        {
            foreach (Person p in family)
            {
                Console.WriteLine($"{p.Name} {p.Age}");
            }
        }
    }
}
