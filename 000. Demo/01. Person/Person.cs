using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _01._Person
{
    public class Person
    {
		private string name;
        private int age;
        private double salary;

        public string Name
		{
			get { return name; }
			set { name = value; }
		}		

		public int Age
		{
			get { return age; }
			set { age = value; }
		}		

		public double Salary
		{
			get { return salary; }
			set { salary = value; }
		}

		public void IntroduceYourself()
		{
            Console.WriteLine($"My name is {this.Name}, {this.Age} years old. Salary: {this.Salary}");
		}

		public override string ToString()
		{
			return $"My name is {this.Name}, {this.Age} years old. Salary: {this.Salary} lv!";
		}

		public string Print()
		{
			return  $"Az sam {this.Name}, {this.Age} godini. Zaplata: {this.Salary} lv!";
        }
	}
}
