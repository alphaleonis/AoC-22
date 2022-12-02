using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AoC22_1
{
   enum RPS
   {
      Rock = 1,
      Paper = 2,
      Scissors = 3
   }

   enum Outcome
   {
      Lose = 1,
      Draw = 2,
      Win = 3
   }

   internal partial class Program
   {
      static void Day02_Part1()
      {
         int total = 0;
         foreach (var line in EnumerateInputLines("day02.txt"))
         {
            var opponent = (RPS)(line[0] - 'A' + 1);
            var me = (RPS)(line[2] - 'X' + 1);
            total += GetScore(opponent, me);
         }

         Console.WriteLine($"Day 02, Part 1: {total}");
      }

      static void Day02_Part2()
      {
         int total = 0;
         foreach (var line in EnumerateInputLines("day02.txt"))
         {
            var opponent = (RPS)(line[0] - 'A' + 1);
            var outcome = (Outcome)(line[2] - 'X' + 1);
            total += GetScore(opponent, GetMove(opponent, outcome));
         }

         Console.WriteLine($"Day 02, Part 2: {total}");
      }

      static int GetScore(RPS opponent, RPS me)
      {
         int score = (int)me;
         int diff = (int)me - (int)opponent;
         if (diff == 1 || diff == -2)
            score += 6;
         else if (diff == 0)
            score += 3;

         return score;
      }

      static RPS GetMove(RPS opponent, Outcome outcome)
      {
         if (outcome == Outcome.Draw)
            return opponent;

         if (outcome == Outcome.Lose)
            return (RPS)(((int)opponent + 1) % 3 + 1);

         return (RPS)(((int)opponent + 3) % 3 + 1);

      }

   }
}
