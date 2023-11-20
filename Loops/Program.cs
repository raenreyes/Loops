using System.Security.Cryptography.X509Certificates;

namespace Loops
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Run();
        }

        public static void Run()
        {
            int i = -10;

            while (true) {
                for (int counter = i; counter < 11; counter++)
                {
                    if (counter % 3 == 0)
                    {
                        continue;
                    }
                    Console.WriteLine(counter);
                }
                if (i == 11)
                {
                    Console.WriteLine(" FINAL BREAK REACHED! This should not happen!");
                    break;
                }
               
                break;
            }


                

                
               


            
        }
    }
}