using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace DuplicateRemoval
{
    public class Operations
    {
        public static List<IO> RemoveDuplicates(List<IO> input)
        {
            var prev = -1;
            for (int i = 0; i < input.Count();)
            {
                if (input[i].Voltage == prev)
                    input.RemoveAt(i);
                else
                {
                    prev = input[i].Voltage;
                    i++;
                }
            }
            return input;
        }
        public static void PrintSignals(List<IO> input)
        {
            foreach (var item in input)
                Console.WriteLine($"{item.UnixTimeStamp}:{item.Voltage}");
        }
        public static List<IO> SortTimeStamp(List<IO> input)
        {
            return input.OrderBy(x=>x.UnixTimeStamp);
        }
    }
}