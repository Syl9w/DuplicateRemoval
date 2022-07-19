using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
namespace DuplicateRemoval
{
    class Program
    {
        private static void Main(string[] args)
        {
            var example = new List<IO>();
            example.Add(new IO { UnixTimeStamp=1615560000, Voltage=1});
            example.Add(new IO { UnixTimeStamp=1615560005, Voltage=1});
            example.Add(new IO { UnixTimeStamp=1615560013, Voltage=1});
            example.Add(new IO { UnixTimeStamp=1615560018, Voltage=1});
            example.Add(new IO { UnixTimeStamp=1615560024, Voltage=0});
            example.Add(new IO { UnixTimeStamp=1615560030, Voltage=1});
            example.Add(new IO { UnixTimeStamp=1615560037, Voltage=0});
            example.Add(new IO { UnixTimeStamp=1615560042, Voltage=0});
            var res = Operations.RemoveDuplicates(example);
            Operations.PrintSignals(res);
        }
    }
}