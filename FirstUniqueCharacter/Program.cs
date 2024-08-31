using System;

namespace FirstUniqueCharacter
{
    public class Program
    {
        //Given a string s, find the first non-repeating character 
        //in it and return its index.If it does not exist, return -1.
        static void Main(string[] args)
        {
            Console.WriteLine("Enter a string:");
            string word = Console.ReadLine();
            Console.WriteLine(FirstUniqChar(word));
        }
        public static int FirstUniqChar(string s)
        {
            char[] array = s.ToCharArray();
            int found = 0;
            int index = -1;
            for (int i = 0; i < array.Length; i++)
            {
                for (int j = 0; j < array.Length; j++)
                {
                    if (array[i] == array[j]) found++;
                }
                if (found == 1)
                {
                    index = i;
                    break;
                }
                found = 0;
            }
            return index;
        }
    }
}

