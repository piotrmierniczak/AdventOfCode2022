namespace AdventOfCode2022
{
	public class Task3
	{
        public static void PartOne()
        {
            Console.WriteLine("We know that:");
            Console.WriteLine($"char a has number: {'a' - 0}");
            Console.WriteLine($"char z has number: {'z' - 0}");
            Console.WriteLine($"char A has number: {'A' - 0}");
            Console.WriteLine($"char Z has number: {'Z' - 0}");
            Console.WriteLine("so the solution is:");

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
    }
}
