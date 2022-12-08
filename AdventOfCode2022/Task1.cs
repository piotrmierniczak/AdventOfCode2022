namespace AdventOfCode2022
{
    public static class Task1
    {
        public static void PartTwo()
        {
            //https://adventofcode.com/2022/day/1
            string[] lines = File.ReadAllLines("TextFile1.txt");
            int tempSum = 0;
            List<int> list = new List<int>();
            foreach (string line in lines)
            {
                if (string.IsNullOrEmpty(line))
                {
                    list.Add(tempSum);
                    tempSum = 0;
                    continue;
                }
                else
                {
                    int.TryParse(line, out int number);
                    tempSum += number;
                }
            }
            list = list.OrderByDescending(x => x).ToList();
            long total = list[0] + list[1] + list[2];
            Console.WriteLine($"Max calories: {list[0]}"); //69289
            Console.WriteLine($"Total three max calories: {total}"); //205615
        }
    }
}