using System.IO;
using System.Text;
using System.Transactions;
public class Program
{
    public static void Main(string[] args)
    {
        // Creating a file
        //Finding and Replacing word in text file.
        string path = @"C:\Users\stefka\source\repos\Training\FindAndReplace\findAdReplace.txt";
        Console.WriteLine("Enter the text you want to save in a file.");
        string text = Console.ReadLine();
        File.WriteAllText(path,text);
        Console.WriteLine("Enter the word you want to replace in file.");
        string word= Console.ReadLine();
        Console.WriteLine("Enter the new word you want to put in file.");
        string wordNew = Console.ReadLine();
        try
        {
            StringBuilder file = new StringBuilder();
            using (StreamReader sr = new StreamReader(path))
            {
                while ((sr.ReadLine()) != null)
                {
                    Console.WriteLine(sr.ReadLine());
                    // file.AppendLine(sr.ReadLine());
                }
            }
            //file.Replace(word, wordNew);
            string newFile= file.ToString();
            Console.WriteLine(file);
            File.WriteAllText("findAndReplace.txt", newFile);
        }
        catch (Exception e)
        {
            Console.WriteLine("The file cannot be read");
            Console.WriteLine(e.Message);
        }
    }
}