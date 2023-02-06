using System;
using System.Collections;

namespace AdventOfCode2022
{
	public class Task5
	{

        public void PartOne()
        {
            List<Stack> stacks = CreateStackList();
            string[] lines = File.ReadAllLines("TextFile5.txt");
            int result = 0;
            foreach (string line in lines)
            {

            }
            Console.WriteLine(result);
        }

        public void PartTwo()
        {
            List<Stack> stacks = CreateStackList();
            string[] lines = File.ReadAllLines("TextFile5.txt");
        }

        private List<Stack> CreateStackList()
        {
            List<Stack> list = new List<Stack>();
            Stack stack1 = new Stack();
            stack1.Push("D");
            stack1.Push("B");
            stack1.Push("J");
            stack1.Push("V");
            list.Add(stack1);
            Stack stack2 = new Stack();
            stack2.Push("P");
            stack2.Push("V");
            stack2.Push("B");
            stack2.Push("W");
            stack2.Push("R");
            stack2.Push("D");
            stack2.Push("F");
            list.Add(stack2);
            Stack stack3 = new Stack();
            stack3.Push("R");
            stack3.Push("G");
            stack3.Push("F");
            stack3.Push("L");
            stack3.Push("D");
            stack3.Push("C");
            stack3.Push("W");
            stack3.Push("Q");
            list.Add(stack3);
            Stack stack4 = new Stack();
            stack4.Push("W");
            stack4.Push("J");
            stack4.Push("P");
            stack4.Push("M");
            stack4.Push("L");
            stack4.Push("N");
            stack4.Push("D");
            stack4.Push("B");
            list.Add(stack4);
            Stack stack5 = new Stack();
            stack5.Push("H");
            stack5.Push("N");
            stack5.Push("B");
            stack5.Push("P");
            stack5.Push("C");
            stack5.Push("S");
            stack5.Push("Q");
            list.Add(stack5);
            Stack stack6 = new Stack();
            stack6.Push("R");
            stack6.Push("D");
            stack6.Push("B");
            stack6.Push("S");
            stack6.Push("N");
            stack6.Push("G");
            list.Add(stack6);
            Stack stack7 = new Stack();
            stack7.Push("Z");
            stack7.Push("B");
            stack7.Push("P");
            stack7.Push("M");
            stack7.Push("Q");
            stack7.Push("F");
            stack7.Push("S");
            stack7.Push("H");
            list.Add(stack7);
            Stack stack8 = new Stack();
            stack8.Push("W");
            stack8.Push("L");
            stack8.Push("F");
            list.Add(stack8);
            Stack stack9 = new Stack();
            stack9.Push("S");
            stack9.Push("V");
            stack9.Push("F");
            stack9.Push("M");
            stack9.Push("R");
            list.Add(stack9);
            return list;
        }
    }
}

