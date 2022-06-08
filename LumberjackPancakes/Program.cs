namespace LumberjackPancakes
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Random random = new Random();
            Queue<Lumberjack> lumberjacks = new Queue<Lumberjack>();

            string name;
            Console.Write("Imię pierwszego drwala: ");
          
            while((name = Console.ReadLine()) != "")
            {
                Console.Write("Liczba naleśników: ");
                if (int.TryParse(Console.ReadLine(), out int number))
                {
                    Lumberjack lumberjack = new Lumberjack(name);
                    for (int i = 0; i < number; i++)
                    {
                        lumberjack.TakeFlapjack((Flapjack)random.Next(0, 4));
                    }
                    lumberjacks.Enqueue(lumberjack);
                }
                Console.Write("Imię następnego drwala (pusty wiersz, aby zakończyć): ");
            }

            while (lumberjacks.Count > 0)
            {
                Lumberjack next = lumberjacks.Dequeue();
                next.EatFlapjacks();
            }

        }
    }
}