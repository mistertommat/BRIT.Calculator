using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.IO;
using System.Threading.Tasks;
using BRIT.Calculator.Entities;
using BRIT.Calculator.Abstract;

namespace BRIT.Calculator.Framework
{
    public class InstructionProcessor : IInstructionProcessor
    {
        FunkyCalc calc;
        private char[] _delimiter;

        public InstructionProcessor(char[] delimiter) {
            _delimiter = delimiter;            
            calc = new FunkyCalc();
        }

        public Instruction GetInstruction(string line) {
                        
            string[] arrLine = line.Split(_delimiter);
            bool result;
            decimal number;
            Instruction instruction = new Instruction(); ;
                
            result = decimal.TryParse(arrLine[1], out number);
            if (result)
            {
                instruction.Operand = number;
                instruction.Operator = (EnumOperator.Operation)Enum.Parse(typeof(EnumOperator.Operation), arrLine[0], true);
            }
            return instruction;
        }

        public decimal ProcessInstructions(List<Instruction> instructions) {           

            decimal number = instructions.Where(i => i.Operator == EnumOperator.Operation.Apply).Select(i => i.Operand).FirstOrDefault();

            foreach (Instruction instructionToProcess in instructions) 
            {                
                switch(instructionToProcess.Operator) {
                    case EnumOperator.Operation.Add:
                        number = calc.AddNumbers(number, instructionToProcess.Operand);
                        break;
                    case EnumOperator.Operation.Subtract:
                        number = calc.SubtractNumbers(number, instructionToProcess.Operand);
                        break;
                    case EnumOperator.Operation.Multiply:
                        number = calc.MultiplyNumbers(number, instructionToProcess.Operand);
                        break;
                    case EnumOperator.Operation.Divide:
                        number = calc.DivideNumbers(number, instructionToProcess.Operand);
                        break;
                    default:
                        break;
                }                
            }
            return number;
        }
    }
}
