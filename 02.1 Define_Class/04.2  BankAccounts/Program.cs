namespace _04._2__BankAccounts
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Person p=new Person("Ivan",20);

            List<BankAccount> asenAccounts = new List<BankAccount>();
            BankAccount asen1 = new BankAccount(1,2000.13);
            asenAccounts.Add(asen1);
            Person asen = new Person("Asen",23,asenAccounts);


            List<BankAccount> petarAccounst = new List<BankAccount>();
            BankAccount petar1 = new BankAccount(1, 1000.23);
            BankAccount petar2 = new BankAccount(2, 2000.33);
            petarAccounst.Add(petar1);
            petarAccounst.Add(petar2);
            Person petar = new Person("Petar",44,petarAccounst);

            Console.WriteLine();
            Console.WriteLine($"{p.Name}, {p.Age} godini");

            Console.WriteLine();
            Console.WriteLine($"{asen.Name}, {asen.Age} godini");
            foreach (var item in asenAccounts)
            {
                Console.WriteLine(item);
            }
            Console.WriteLine($"Total: {asen.GetBalance()}");


            Console.WriteLine();
            Console.WriteLine($"{petar.Name}, {petar.Age} godini");
            foreach (var item in petarAccounst)
            {
                Console.WriteLine(item);
            }
            Console.WriteLine($"Total: {petar.GetBalance()}");


        }
    }
}
