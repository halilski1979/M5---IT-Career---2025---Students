namespace _02._2___Family
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int n = int.Parse(Console.ReadLine());

            Family ivanovi = new Family();
            
            for (int i = 0; i < n; i++)
            {
                var line = Console.ReadLine().Split(' ').ToList();
                var ime = line[0];
                var godini=int.Parse(line[1]);
                ivanovi.AddMember(ime, godini);
            }

            Console.WriteLine();       
            ivanovi.Print();

            Console.WriteLine("==============");
            ivanovi.SortNameLessThan30();
        }
    }
}
