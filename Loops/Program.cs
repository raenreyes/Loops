using System.Security.Cryptography.X509Certificates;

namespace Loops
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Average();
        
        }
        public static void Average ()
        {         
            bool arraySuccess;
            int counter = 0;
            double average = 0;
            int dontCount = 1;
            do
            {
                Console.WriteLine("Enter how much test scores you will enter: ");
                string arraySize = Console.ReadLine();
                arraySuccess = int.TryParse(arraySize, out counter);
            }
            while (arraySuccess == false);

            double[] inputs = new double[counter];

            for (int i = 0; i < counter; i++)
            {                
                bool success = false;
                double parsedNum;
                do
                {
                    Console.WriteLine("Please score: " + dontCount);
                    string numString = Console.ReadLine();
                    success = double.TryParse(numString, out parsedNum);
                    
                    if (parsedNum < 0 || parsedNum > 20)
                    {   
                        if (parsedNum == -1)
                        {
                            break;
                        }
                        success = false;
                    }                 
                    inputs[i] = parsedNum;
                } while (success == false);
                dontCount++;
                if (parsedNum == -1)
                {
                    break;
                }
            }           
            for (int j = 0; j < inputs.Length; j++)
            {
                 average += inputs[j];
                
            }
            Console.WriteLine("The total of all the points before dividing is " + average);
            average = average / inputs.Length;

            Console.WriteLine("The Average of all your numbers is " + average);

        }
    }
}