using System.Security.Cryptography.X509Certificates;

namespace Loops
{
    internal class Program
    {
        static void Main(string[] args)
        {

            ForLoop();
            WhileLoop();
        }
        public static void ForLoop() { 
            for(int i = -3; i <= 3; i++)
            {
                Console.WriteLine(i);
            }
            
        }
        public static void WhileLoop()
        {
            int num = 3;
            while(num < 4 && num > -4)
            {
              
                Console.WriteLine(num);
                num--;

            }
        }
        
    }
}