namespace opdracht1
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("geef een naam");
            string input = Console.ReadLine();
            int naam = 0;
            naam = int.Parse(input);

            Console.WriteLine("geef nog een naam");
            string input2 = Console.ReadLine();
            int vrouw = 0;
            vrouw = int.Parse(input2);

            Console.WriteLine("geef een gerecht");
            string input3 = Console.ReadLine();
            int gerecht = 0;
            gerecht = int.Parse(input3);

        }
    }
}