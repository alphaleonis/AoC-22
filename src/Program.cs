using System;
using System.Reflection;

namespace AoC22_1
{   
   internal partial class Program
   {
      static void Main(string[] args)
      {
         Day01_Part1();
         Day01_Part2();
         Day02_Part1();
         Day02_Part2();        
      }


      private static string GetInputFilePath(string name) => Path.Combine(Path.GetDirectoryName(Assembly.GetExecutingAssembly().Location)!, "input", name);

      private static StreamReader OpenInput(string name)
      {
         return new StreamReader(GetInputFilePath(name));
      }

      private static IEnumerable<string> EnumerateInputLines(string name)
      {
         using var reader = OpenInput(name);
         string? line;
         while ((line = reader.ReadLine()) != null)
         {
            yield return line;
         }
      }
   }
}