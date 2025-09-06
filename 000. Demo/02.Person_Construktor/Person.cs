using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _02.Person_Construktor
{
    public class Person
    {
		private string name;
        private int age;
        private double salary;

        public Person(string name, int age, double salary)
        {
            this.Name = name;
            this.Age = age;
            this.Salary = salary;
        }

		//Дефолтен конструктор
		public Person()
		{
			
		}

        public string Name
		{
			get { return name; }
			set 
			{
				if (string.IsNullOrEmpty(value) || value.Length<=2)
				{
					throw new ArgumentException("Error name");
				}
				name = value; 
			}
		}		

		public int Age
		{
			get { return age; }
			set
			{ 
				if (value < 0)
				{
					throw new ArgumentException("Error age");
				}
				age = value; 
			}
		}		

		public double Salary
		{
			get { return salary; }
			set { salary = value; }
		}

		public override string ToString()
		{
			return $"{this.Name},{this.Age} godini, Zaplata: {this.Salary}";
		}

	}
}
