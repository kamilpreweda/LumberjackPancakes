namespace LumberjackPancakes
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Random random = new Random();
            Queue<Lumberjack> lumberjacks = new Queue<Lumberjack>();

            Console.Write("Imię pierwszego drwala: ");
            string name = Console.ReadLine();
            while(name != null)
            {
                Console.Write("Liczba naleśników: ");
                if (int.TryParse(Console.ReadLine(), out int number))
                {
                    Lumberjack lumberjack = new Lumberjack(name);
                }
            }

        }
    }
}