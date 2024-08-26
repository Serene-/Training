namespace Hangman
{
    public class Program
    {
        static string pathDirectory = @"C:\Users\stefka\source\repos\Training\Hangman";
        static string path;
        static int score = 0;
        static int bestScore=0;
        static StreamReader sr;
        static void Main(string[] args)
        {
            CreateFileWithWords();
            path = Path.Combine(pathDirectory,"words.txt");
            string wordToGuess;
            Console.WriteLine("Welcome to Hangman!");
            Console.WriteLine("Guess the word");
            try
            {
                using (sr = new StreamReader(path))
                {
                    
                    while (!sr.EndOfStream)
                    {
                        wordToGuess = sr.ReadLine();
                        Console.WriteLine("Word:");
                        GuessingWords(wordToGuess);
                        Console.WriteLine("Do you want to continue with the game y/n?");
                        if (Console.ReadLine().ToLower() == "n") break;
                    }
                    path = Path.Combine(pathDirectory, "bestscore.txt");
                    if(File.Exists(path))
                    {
                        using (StreamReader srBestScore=new StreamReader(path))
                        {
                            bestScore = Int32.Parse(srBestScore.ReadLine());
                        }
                    }
                    else
                    {
                        File.WriteAllText(path, score.ToString());

                    }
                    if (bestScore <= score)
                    {
                        Console.WriteLine($"You have the best score of all time {score}!");
                        File.WriteAllText(path, score.ToString());
                    }
                    else
                    {
                        Console.WriteLine($"The best score is {bestScore}, your is {score}!");
                        File.WriteAllText(path, bestScore.ToString());
                    }
                    }
            }
            catch (Exception e)
            {
                Console.WriteLine(e.Message);
            }
        }

        public static void GuessingWords(string wordToGuess)
        {
            char[] word = new char[wordToGuess.Length];
            char letter;
            string guessedWord=null;
            for (int i = 0; i < wordToGuess.Length; i++)
            {
                word[i] = '-';
            }
            Console.WriteLine(word);
            for (int i = 0; i < 6; i++)
            {
                Console.WriteLine($"You have {6 - i} guesses left.Please enter a letter:");
                   letter = Char.Parse(Console.ReadLine());
                    for (int j = 0; j < wordToGuess.Length; j++)
                    {
                        if (letter == wordToGuess[j]) word[j] = letter;

                    }
                    guessedWord = new string(word);
                    Console.WriteLine(word);
                    if (guessedWord.Equals(wordToGuess))
                    {
                        Console.WriteLine("Congratulations!!! You guessed the word!");
                        score++;
                        Console.WriteLine($"Your score is {score}");
                        i = 6;
                    }              
            }
            if (!guessedWord.Equals(wordToGuess))
            {
                Console.WriteLine($"You didn't guess the word. The word was {wordToGuess}");
            }
        }

        public static void CreateFileWithWords()
        {
            string words = @"apple
plum
pine
bag
smell";
            string path = Path.Combine(pathDirectory, "words.txt");
            File.WriteAllText(path, words);
        }


    }
}
