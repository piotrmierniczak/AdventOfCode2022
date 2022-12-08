﻿namespace AdventOfCode2022
{
    public static class Task2
    {
        //https://adventofcode.com/2022/day/2
        //A and X - rock = 1 point
        //B and Y - paper = 2 points
        //C and Z - scissors = 3 points
        //you loss = 0 points
        //draw = 3 points
        //you win = 6 points
        static Dictionary<string, int> results = new Dictionary<string, int>()
            {
                {"AX", 4}, //Two rocks. Draw. 3 + 1 = 4
                {"AY", 8}, //Rock loss with paper. You win. 6 + 2 = 8
                {"AZ", 3}, //Rock win with scissor. You loss. 0 + 3 = 3
                {"BX", 1}, //Paper win with rock. You loss. 0 + 1 = 1
                {"BY", 5}, //Two papers. Draw. 3 + 2 = 5
                {"BZ", 9}, //Paper loss with scissor. You win 6 + 3 = 9
                {"CX", 7}, //Scissor loss with rock. You win 6 + 1 = 7
                {"CY", 2}, //Scissor win with paper. You loss. 0 + 2 = 2
                {"CZ", 6}  //Two scissors. Draw. 3 + 3 = 6
            };
        public static void PartOne()
        {
            string[] lines = File.ReadAllLines("TextFile2.txt");
            int result = 0;
            foreach (string line in lines)
            {
                string round = line.Replace(" ","");
                result += results.FirstOrDefault(x => x.Key == round).Value;
            }
            Console.WriteLine($"Result: {result}"); //11449
        }

        public static void PartTwo()
        {
            string[] lines = File.ReadAllLines("TextFile2.txt");
            int result = 0;
            foreach (string line in lines)
            {
                string round = line.Replace(" ", "");
                result += results.FirstOrDefault(x => x.Key == round).Value;
            }
            Console.WriteLine($"Result: {result}"); //11449
        }
    }
}