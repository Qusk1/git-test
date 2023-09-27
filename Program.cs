namespace git_test
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Hello, Git!");

            for (int i = 0; i < 10; i++)
            {
                for (int j = 0; j < 10; j++)
                {
                    if ((j + i) % 2 == 0)
                    {
                        Console.Write("#");
                    }
                    else
                    {
                        Console.Write("¤");
                    }
                   
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