using System;
using System.Collections.Generic;
using System.Linq;
using System.Reflection;
using System.Text;
using System.Threading.Tasks;

namespace AoC22_1
{
   internal partial class Program
   {
      public static void Day01_Part1()
      {
         int current = 0;
         int max = 0;
         foreach (var line in EnumerateInputLines("day01.txt"))
         {
            if (Int32.TryParse(line, out var value))
            {
               current += value;
            }
            else
            {
               max = Math.Max(current, max);
               current = 0;
            }
         }

         Console.WriteLine($"Day 01, Part 1: {max}");

      }

      public static void Day01_Part2()
      {
         SortedSet<int> s = new SortedSet<int>();

         int current = 0;
         foreach (var line in EnumerateInputLines("day01.txt"))
         {
            if (Int32.TryParse(line, out var value))
            {
               current += value;
            }
            else
            {
               if (s.Count < 3)
               {
                  s.Add(current);
               }
               else
               {
                  if (current > s.Min)
                  {
                     s.Remove(s.Min);
                     s.Add(current);
                  }
               }
               current = 0;

            }
         }

         Console.WriteLine($"Day 02, Part 2: {s.Sum()}");         
      }
   }
}
