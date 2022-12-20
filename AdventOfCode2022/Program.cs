// See https://aka.ms/new-console-template for more information
using AdventOfCode2022;

//Console.WriteLine("Task1");
//Task1.PartTwo();
//Console.WriteLine();

//Console.WriteLine("Task2. Part One.");
//Task2.PartOne();
//Console.WriteLine();
//Console.WriteLine("Task2. Part Two.");
//Task2.PartTwo();
//Console.WriteLine();

Task3.PartOne();
string[] lines = File.ReadAllLines("TextFile3.txt");

int result = 0;
for (int i = 0; i < lines.Length; i += 3)
{
    string first = lines[i];
    string second = lines[i+1];
    string third = lines[i+2];
    for (int j = 0; j < first.Length; j++)
    {
        char letter = first[j];
        if(second.Contains(letter) && third.Contains(letter))
        {
            int number = letter - 0;
            number -= number >= 97 ? 96 : 38; // a(97) - 96 = 1, A(65) - 38 = 27
            result += number;
            break;
        }
    }
}
Console.WriteLine(result);
