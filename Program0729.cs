using static System.Console;
namespace ConsoleApp0729
    //
{
    internal class Program
    {
        public static int f(int n)
        {
            if (n == 1)
            {
                return 1;
            }else{
                return n * f(n - 1);
            }
        }
        static void Main(string[] args)
        {
            int x = f(5);
            WriteLine(x);
        }
    }
}
