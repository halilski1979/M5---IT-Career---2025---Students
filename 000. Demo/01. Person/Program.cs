namespace _01._Person
{
    internal class Program
    {
        static void Main(string[] args)
        {
            
           
            List<Person> people=new List<Person>();
            
            
            Person person = new Person();
            person.Name = "Test";
            person.Age = 30;
            person.Salary = 2050.33;
            people.Add(person);

            Person person1 = new Person();
            person1.Name = "Ivan";
            person1.Age = 40;
            person1.Salary = 3350.33;
            people.Add (person1);

            Person person2 = new Person();
            person2.Name = "Asen";
            person2.Age = 20;
            person2.Salary = 4450.33;
            people.Add(person2);


            Console.WriteLine(person.Name);
            Console.WriteLine(person.Age);
            Console.WriteLine(person.Salary);

            Console.WriteLine();
            person.IntroduceYourself();

            Console.WriteLine();
            Console.WriteLine(person);

            Console.WriteLine();
            Console.WriteLine(person.Print());

            Console.WriteLine();
            Console.WriteLine("Print List:");
            foreach (var item in people)
            {
               item.IntroduceYourself ();
            }
        }
    }
}
