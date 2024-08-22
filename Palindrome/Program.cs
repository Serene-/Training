namespace Palindrome
{
    public class Program
    {
        static void Main(string[] args)
        {
            string command = String.Empty;
            while(command!="END" || command!="End")
            {
                Console.WriteLine("Please enter the word you want to check if it is palindrome or END to end the program");
                command = Console.ReadLine();
            }
        }
    }
}
