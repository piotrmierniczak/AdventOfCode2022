namespace AdventOfCode2022
{
    public static class Task2
    {
        //https://adventofcode.com/2022/day/2
        //A - rock = 1 point
        //B - paper = 2 points
        //C - scissors = 3 points
        //you loss = 0 points
        //draw = 3 points
        //you win = 6 points
        public static void PartOne()
        {
            //X - rock = 1 point
            //Y - paper = 2 points
            //Z - scissors = 3 points
            Dictionary<string, int> results = new()
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
            CalculateEachRow(results); //11449
        }

        public static void PartTwo()
        {
            //X - you loss = 0 points
            //Y - draw = 3 points
            //Z - you win = 6 points
            Dictionary<string, int> results = new()
            {
                {"AX", 3}, //Rock. You loss, so you have scissor. 0 + 3 = 3
                {"AY", 4}, //Rock. Draw, so you have rock. 3 + 1 = 4
                {"AZ", 8}, //Rock. You win, so you have paper. 6 + 2 = 8
                {"BX", 1}, //Paper. You loss, so you have rock. 0 + 1 = 1
                {"BY", 5}, //Paper. Draw, so you have paper. 3 + 2 = 5
                {"BZ", 9}, //Paper. You win, so you have scissors. 6 + 3 = 9
                {"CX", 2}, //Scissors. You loss, so you have paper. 0 + 2 = 2
                {"CY", 6}, //Scissors. Draw, so you have scissors. 3 + 3 = 6
                {"CZ", 7}  //Scissors. You win, so you have rock. 6 + 1 = 7
            };
            CalculateEachRow(results);
        }

        private static void CalculateEachRow(Dictionary<string, int> results)
        {
            string[] lines = File.ReadAllLines("TextFile2.txt");
            int result = 0;
            foreach (string line in lines)
            {
                string round = line.Replace(" ", "");
                result += results.FirstOrDefault(x => x.Key == round).Value;
            }
            Console.WriteLine($"Result: {result}"); 
        }
    }
}