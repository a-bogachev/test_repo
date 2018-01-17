using System;
using System.Numerics;
namespace test_repo
{
    class Program
    {
        public static BigInteger fib(BigInteger n)
        {
            BigInteger res = 0, i=0;
            if (n == 1) return 1;
            if (n == 2) return 2;
            res = 2;
            BigInteger a = 1, b = 1, c=0;
            for (i=3; i<=n; i++)
            {
                c = a + b;
                a = b;
                b = c;
                res += c;
            }
            return res;
        }
        static void Main(string[] args)
        {
            BigInteger a;
            a=Convert.ToInt32(Console.ReadLine());
            Console.WriteLine(Program.fib(a));
            Console.ReadKey();
        }
    }
}
