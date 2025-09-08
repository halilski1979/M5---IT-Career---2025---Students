namespace _02._2_RationalNumbers
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int n = int.Parse(Console.ReadLine());

            List<RationalNumbers> drob = new List<RationalNumbers>();

            for (int i = 0; i < n; i++)
            {
               //Даваме стойности за числител и знаменател
               int numerator=int.Parse(Console.ReadLine());
               int denominator=int.Parse(Console.ReadLine());
                
               //Създаваме си обект
               RationalNumbers number = new RationalNumbers(numerator,denominator);

                //Добавяме го към списък от тип  RationalNumbers
                drob.Add(number);
            }

            foreach (RationalNumbers number in drob)
            {
                //Console.WriteLine(number);
                number.Print();
            }

            
        }
    }
}
