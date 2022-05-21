﻿// See https://aka.ms/new-console-template for more information
Console.WriteLine("Hello, World!");

var path = @"C:\Users\naard\Dev\Projects\random-text-generator\cicero.txt";

string latinText = File.ReadAllText(path);
string[] words = latinText.Split(' ');

System.Console.WriteLine($"len of words is {words.Count()}");

var sentence = RandomSentence(words);

System.Console.WriteLine(sentence);

string RandomSentence(string[] words)
{
    var rnd = new Random();
    var sentenceLength = rnd.Next(3, 10);

    var wordsOfSentence = new string[sentenceLength];

    for (int i = 0; i < sentenceLength; i++)
    {
        wordsOfSentence[i] = words[rnd.Next(words.Count())];
    }
    var sentence = string.Join(" ", wordsOfSentence);


    return EndSentence(UppercaseFirstLetter(sentence));
}

static string UppercaseFirstLetter(string s)
{
    // Check for empty string.
    if (string.IsNullOrEmpty(s))
    {
        return string.Empty;
    }
    // Return char and concat substring.
    return char.ToUpper(s[0]) + s.Substring(1);
}
static string EndSentence(string s)
{
    if (string.IsNullOrEmpty(s))
    {
        return string.Empty;
    }
    return s = s + ".";
}