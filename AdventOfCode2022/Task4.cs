namespace AdventOfCode2022
{
	public class Task4
	{
        public static void PartOne()
        {
            string[] lines = File.ReadAllLines("TextFile4.txt");
            int result = 0;
            foreach (string line in lines)
            {
                string[] pairs = line.Split(",");
                int[] pair1 = pairs[0].Split("-").Select(int.Parse).ToArray();
                int[] pair2 = pairs[1].Split("-").Select(int.Parse).ToArray();
                int number1 = pair1[0];
                int number2 = pair1[1];
                int number3 = pair2[0];
                int number4 = pair2[1];
                if ((number1 >= number3 && number2 <= number4) || (number1 <= number3 && number2 >= number4))
                {
                    result++;
                }
            }
            Console.WriteLine(result);
        }

        public static void PartTwo()
        {
            string[] lines = File.ReadAllLines("TextFile4.txt");
            int result = 0;
            foreach (string line in lines)
            {
                string[] pairs = line.Split(",");
                int[] pair1 = pairs[0].Split("-").Select(int.Parse).ToArray();
                int[] pair2 = pairs[1].Split("-").Select(int.Parse).ToArray();
                int number1 = pair1[0];
                int number2 = pair1[1];
                int number3 = pair2[0];
                int number4 = pair2[1];
                bool pair1BeforePair2 = number2 < number3;
                bool pair1AfterPair2 = number1 > number4;
                if (!(pair1BeforePair2 || pair1AfterPair2))
                {
                    result++;
                }
            }
            Console.WriteLine(result);
        }
    }
}
