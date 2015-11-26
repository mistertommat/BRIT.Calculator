using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using BRIT.Calculator.Entities;

namespace BRIT.Calculator.Abstract
{
    public interface IInstructionProcessor
    {
        Instruction GetInstruction(string line);
        decimal ProcessInstructions(List<Instruction> instructions);
    }
}
