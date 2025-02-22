using System;
using System.IO;
using System.Collections.Generic;
using System.Linq;
using System.Text.RegularExpressions;
class WordCount
{
    static void Main()
    {
        string filePath = "large_text.txt"; 
        Dictionary<string, int> wordCounts = new Dictionary<string, int>(StringComparer.OrdinalIgnoreCase);

        using (StreamReader reader = new StreamReader(filePath))
        {
            string line;
            while ((line = reader.ReadLine()) != null)
            {
                string[] words = Regex.Split(line.ToLower(), "\W+"); // Split by non-word characters
                foreach (string word in words)
                {
                    if (!string.IsNullOrEmpty(word))
                    {
                        if (wordCounts.ContainsKey(word))
                            wordCounts[word]++;
                        else
                            wordCounts[word] = 1;
                    }
                }
            }
        }

        var topWords = wordCounts.OrderByDescending(w => w.Value).Take(5);

        Console.WriteLine("Top 5 most frequent words:");
        foreach (var word in topWords)
        {
            Console.WriteLine($"{word.Key}: {word.Value}");
        }
    }
}

