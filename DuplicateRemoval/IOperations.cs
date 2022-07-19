using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace DuplicateRemoval
{
    public interface IOperations
    {
        List<IO> RemoveDuplicates(List<IO> input);
        void PrintSignals(List<IO> input);

    }
}