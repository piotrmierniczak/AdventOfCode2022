namespace AdventOfCode2022
{
	public class Task3
	{
        /*
         * a = 97
         * z = 122
         * A = 65
         * Z = 90
         */
        public static void PartOne()
        {
            string[] lines = File.ReadAllLines("TextFile3.txt");

            int result = 0;
            foreach (string line in lines)
            {
                int half = line.Length / 2;
                string firstPart = line.Substring(0, half);
                string secondPart = line.Substring(half, half);
                for (int i = 0; i < firstPart.Length; i++)
                {
                    char letter = firstPart[i];
                    if (secondPart.Contains(letter))
                    {
                        int number = letter - 0;
                        number -= number >= 97 ? 96 : 38; // a(97) - 96 = 1, A(65) - 38 = 27
                        result += number;
                        break;
                    }
                }
            }
            Console.WriteLine(result);
        }

        public static void PartTwo()
        {
            string[] lines = File.ReadAllLines("TextFile3.txt");

            int result = 0;
            for (int i = 0; i < lines.Length; i += 3)
            {
                string first = lines[i];
                string second = lines[i + 1];
                string third = lines[i + 2];
                for (int j = 0; j < first.Length; j++)
                {
                    char letter = first[j];
                    if (second.Contains(letter) && third.Contains(letter))
                    {
                        int number = letter - 0;
                        number -= number >= 97 ? 96 : 38; // a(97) - 96 = 1, A(65) - 38 = 27
                        result += number;
                        break;
                    }
                }
            }
            Console.WriteLine(result);
        }
    }
}
