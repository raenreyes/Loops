namespace Loops
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int text = 0;
            string fullName = "";
            do 
            { 
                Console.WriteLine("Enter your name: ");
                string input = Console.ReadLine();
                text += input.Length;
                fullName += input;
            } 
            while (text < 20);
            Console.WriteLine("Hello Your full name was " + fullName);
        }
    }
}