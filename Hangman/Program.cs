namespace Hangman
{
    public class Program
    {

        static void Main(string[] args)
        {
            string words= @"apple
plum
vinegar
bedroom
enviroment";
            string path = @"C:\Users\stefka\source\repos\Training\Hangman\words.txt";
            File.WriteAllText(path,words);
            string wordToGuess;
            Console.WriteLine("Guess the word");
            try 
            {
                using (StreamReader sr = new StreamReader(path))
                {
                    while(!sr.EndOfStream)
                    {
                        wordToGuess=sr.ReadLine();
                        Console.WriteLine("Word:");
                        GuessingWords(wordToGuess);
                    }
                }
            }
            catch(Exception e)
            {
                Console.WriteLine("ERROR");
            }
        }

        public static void GuessingWords(string wordToGuess)
        {
           // char[] word = wordToGuess.ToCharArray();
            char[] word=new char[wordToGuess.Length];
            char letter;
            for (int i = 0; i < wordToGuess.Length; i++)
            {
                word[i] = '-';
            }
            Console.WriteLine(word);
            for (int i = 0; i < 6; i++)
            {
                Console.WriteLine($"You have {6-i} guesses left.Please enter a letter:");
                letter = Char.Parse(Console.ReadLine());
                for (int j = 0; j < wordToGuess.Length; j++)
                {
                    if (letter == wordToGuess[j]) word[j] = letter;
                   
                }
                string temp = new string(word);
                Console.WriteLine(word);
                if (temp.Equals(wordToGuess))
                {
                    Console.WriteLine("Congratulations!!! You guessed the word!");
                    i = 6;
                }
            }
        }

    }
}
