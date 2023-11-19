namespace Loops
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Please enter what grade you are in (1-4) in highschool");
            string grade = Console.ReadLine();
            int numberGrade = int.Parse(grade);
            while (numberGrade < 1 || numberGrade > 4)
            {
                Console.WriteLine("Invalid please enter a valid grade number");
                Console.WriteLine("Please enter what grade you are in (1-4) in highschool");
                grade = Console.ReadLine();
                numberGrade = int.Parse(grade);
            }
            Console.WriteLine("You entered a valid grade number of " + numberGrade);
        }
    }
}