using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BRIT.Calculator.Entities
{
    public class Instruction
    {
        public EnumOperator.Operation Operator { get; set; }
        public decimal Operand { get; set; }        
    }
}
