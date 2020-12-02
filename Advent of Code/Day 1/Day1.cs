using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;



//--- Day 1: Report Repair ---
//Before you leave, the Elves in accounting just need you to fix your expense report (your puzzle input); apparently, something isn't quite adding up.
//Specifically, they need you to find the two entries that sum to 2020 and then multiply those two numbers together.
//For example, suppose your expense report contained the following:

//1721
//979
//366
//299
//675
//1456

//In this list, the two entries that sum to 2020 are 1721 and 299. Multiplying them together produces 1721 * 299 = 514579, so the correct answer is 514579.
//Of course, your expense report is much larger. Find the two entries that sum to 2020; what do you get if you multiply them together?

namespace Advent_of_Code.Day_1
{
    class Day1
    {
        //My Input
        private readonly List<string> input = System.IO.File.ReadLines("./input1.txt").ToList();

        //Finds the two entries that sum to 2020
        public void FindSum()
        {
            //Flag
            bool notFound = true;
            int pos = 0;
            do
            {
                pos++;
                for (int i = 1; i < input.Count(); i++)
                {

                    int magic_number = 2020;
                    int x = Int32.Parse(input[pos]);
                    int y = Int32.Parse(input[i]);
                    int sum = x + y;

                    if (sum == magic_number)
                    {
                        notFound = false;
                        Console.WriteLine("The two entries that sum to 2020 are: " + x + " and " + y);
                        Console.WriteLine("If you multiply them together, you get: " + x * y);
                    }
                }
            } while (notFound);
        }
    }
}
