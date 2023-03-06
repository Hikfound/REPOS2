using System;

namespace ConsoleApp5
{
    class Program
    {
        static void Main(string[] args)
        {
            Random random = new Random();
            //for (int i=1;i<=10;i++)
            //{
            //    int x = random.Next(-40, 40);
            //    Console.WriteLine(x);
            //}
            int count = 0;
            for (int i=1;i<=15;i++)
            {
                double x = -20+50*random.NextDouble();
                Console.WriteLine(x);
                if (x>0)
                    {
                    count++;
                }
            }
            Console.WriteLine{$"Количество положит.={count}"};
            Console.Read();
        }
    }
}
