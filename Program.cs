namespace git_test
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Hello, Git!");

            for (int i = 0; i < 10; i++)
            {
                Console.Write("#");

                for (int j = 0; j < 10; j++)
                {
                    Console.Write("#");
                }
                Console.WriteLine();
            }

            Hej();
        }

        static void Hej()
        {
            Console.WriteLine("Hejhej");
            Console.WriteLine("Hello, Gren!");
        }
    }
}