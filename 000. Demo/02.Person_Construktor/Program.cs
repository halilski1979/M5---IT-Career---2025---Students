namespace _02.Person_Construktor
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Person p=new Person();


            Person p1 = new Person("Iv",12,2500.23);

            Console.WriteLine(p);
            Console.WriteLine(p1);
        }
    }
}
