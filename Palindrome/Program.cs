using System.Runtime.InteropServices;

namespace Palindrome
{
    public class Program
    {
        static void Main(string[] args)
        {
            
            string command = String.Empty;
            do
            {
                Console.WriteLine("Please enter a word you want to check if it is a palindrome or END to finish the program");
                command = Console.ReadLine();
                if (command == Reverse(command))
                {
                    Console.WriteLine("Palindrome");
                }
                else Console.WriteLine("Not a Palindrome");
            }
            while (command != "END");
        }
        public static string Reverse(string text)
        {
            char[] array=text.ToCharArray();
            Array.Reverse(array);
            string reversed = new string(array);
            return reversed;
        }
    }
}

