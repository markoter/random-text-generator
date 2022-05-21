// See https://aka.ms/new-console-template for more information
Console.WriteLine("Hello, World!");

var path = @"C:\Users\naard\Dev\Projects\random-text-generator\cicero.txt";

string latinText = File.ReadAllText(path);
string[] words = latinText.Split(' ');

System.Console.WriteLine(RandomParagraph(words));



//methods
static string RandomParagraph(string[] words)
{
    var rnd = new Random();
    var paragraphLength = rnd.Next(5, 15);
    var sentencesOfParagraph = new string[paragraphLength];

    for (int i = 0; i < paragraphLength; i++) {
        sentencesOfParagraph[i] = RandomSentence(words);
    }
    return string.Join(" ", sentencesOfParagraph);

}

static string RandomSentence(string[] words)
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

    var chance = new Random().Next(101);
    char punkt;
    if (chance < 85)
    {
        punkt = '.';
    }
    else if (chance < 97)
    {
        punkt = '?';
    }
    else
    {
        punkt = '!';
    }
    return s = s + punkt;
}