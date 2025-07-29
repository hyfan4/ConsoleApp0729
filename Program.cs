using static System.Console;
namespace ConsoleApp729
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int a = 0;
            int b = 1;
            int result = 0;
            Write($"{a} {b} ");

            for (int i = 2; i < 10; i++)
            {
                result = a + b;
                a = b;
                b = result;

                Write($"{result} ");
            }

        }
    }
}

