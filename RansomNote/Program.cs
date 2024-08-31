using Microsoft.VisualBasic;

namespace RansomNote
{
    //Given two strings ransomNote and magazine, return true if ransomNote 
    //can be constructed by using the letters from magazine and false otherwise.
    //Each letter in magazine can only be used once in ransomNote
    public class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Enter string1:");
            string ransomNote=Console.ReadLine();
            Console.WriteLine("Enter string2:");
            string magazine=Console.ReadLine();
            char[] ransomArray = ransomNote.ToCharArray();
            char[] magArray = magazine.ToCharArray();
            int lettersFound=0;
            int count = ransomArray.Length;
            for(int i=0;i<magArray.Length;i++)
            {
                for(int j=0;j<ransomArray.Length;j++)
                {
                    if (magArray[i] == ransomArray[j])
                    {
                        lettersFound++;
                        break;
                    }
                }
            }
            if(count==lettersFound) Console.WriteLine("true");
            else Console.WriteLine("false");
        }
    }
}
