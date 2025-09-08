namespace _02._2_RationalNumbers2
{
    internal class Program
    {
        static void Main(string[] args)
        {
            List<RationalNumbers> numbers= new List<RationalNumbers>();
            var line=Console.ReadLine().Split(' ').Select(int.Parse).ToList();
            
           
            for (int i = 0; i < line.Count; i+=2)
            {
               int numerator=line[i];
               int denumerator=line[i+1];
               
               RationalNumbers number = new RationalNumbers(numerator, denumerator);
               numbers.Add(number);
            }

            Console.WriteLine(string.Join("; ",numbers));
        }
    }
}
