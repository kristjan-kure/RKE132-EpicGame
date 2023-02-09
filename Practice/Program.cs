﻿string path = @"C:\Users\krist\source\repos\Week8EpicGame\Data";
string fileName = "chuck.txt";


string[] lines = File.ReadAllLines(Path.Combine(path, fileName));

ShowFileContent(lines);

static void ShowFileContent(string[] fileContentArray)
{
    int i = 1;

    foreach(string line in fileContentArray)
    {
        Console.WriteLine($"{i}. {line}");
        i++;
    }
}

