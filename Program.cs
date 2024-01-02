using System.ComponentModel.Design;

namespace practice1
{
    internal class Program
    {
        static void Main(string[] args)
        {
            {
                Console.WriteLine("Plz enter a num");
                int x = int.Parse(Console.ReadLine());
                int y = fibo(x);
                Console.WriteLine(y);
                Console.ReadKey();
                   
                    

            }
        }
        static int fibo(int x)
        {
            if (x == 1)
                return 0;
            else if (x == 2)
                return 1;
            else if (x > 2)
                return fibo(x - 1) + fibo(x - 2);
            else
                return -1;
        }
        


    }
}
