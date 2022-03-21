using System;

namespace project
{
    public class ExtractStringTask
    {
        static string ExtractString(string word)
        {
            string extractedWord = string.empty;
            bool firstOccurrence = false;
            bool secondOccurrence = false;

            for (int i = 0; i <= word.Length - 1; i++)
            {
                if (word[i] == '#' && word[i + 1] == '#')
                {
                    firstOccurrence = true;
                    for (int j = i + 2; j <= word.Length - 1; j++)
                    {
                        if (word[j] == '#' && word[j + 1] == '#')
                        {
                            secondOccurrence = true;
                            return extractedWord;
                        }
                        extractedWord += word[j];
                    }
                }
            }

            return string.empty;
        }

        static void Main(string[] args)
        {
            Console.WriteLine(ExtractString("kFp##jFoRj##pL")); // jFoRj
            Console.WriteLine(ExtractString("abc##def"));       // /empty string/
            Console.WriteLine(ExtractString("##123456789##"));  // 123456789
            Console.WriteLine(ExtractString("no####thing"));    // /empty string/
            Console.WriteLine(ExtractString("empty"));          // /empty string/
        }
    }
}
