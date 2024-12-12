using System.Diagnostics;

namespace ConsoleApp1
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Stopwatch sw = new Stopwatch();

            sw.Start();

            for (int i = 0; i < 1000; i++)
            {
                Console.WriteLine(i);
            }

            sw.Stop();

            Console.WriteLine($"Время выполнения программы: {sw.ElapsedMilliseconds}");

            sw.Restart();
            
            for (int i = 0; i < 200; i++)
            {
                Console.WriteLine(i);
            }

            sw.Stop();
            

            Console.WriteLine($"Время выполнения программы: {sw.ElapsedMilliseconds}");

        }
    }
}
