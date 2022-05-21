// See https://aka.ms/new-console-template for more information
Console.WriteLine("Hello, World!");

var path = @"C:\Users\naard\Dev\Projects\random-text-generator\cicero.txt";

string latinText = File.ReadAllText(path);
string[] words = latinText.Split(' ');

System.Console.WriteLine(words[1]);


