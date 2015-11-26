BRIT.Calculator

Components:

Entities - 
EnumOperator - A public enum to define types of operators (Add, Multiply etc.)
Instruction - One Instruction that consitsts of an Operator and Operand

Framework -
InstructionProcessor.cs - The engine that does the job of converting string to instructions. Implements IInstructionProcessor interface. The delimiter seperating the operator and the operand in a string is passed as the contructor to this class. For unit testing, this will be injected using Ninject.

FunkyCalc.cs - Implements ICalculator interface. Provides methods to perform basic mathematical operations.

Program.cs - The main unit of the Console Application that reads a file on C:\ drive and calls the GetInstruction() method of InstructionProcessor for every line in the file. Every instruction corresponding to each line in the file is stored in a list of Instruction (instructions) which is then passed to the ProcessInstructions method of the InstructionProcessor and a decimal of the final result is returned and displayed on the console.

Unit Tests
Instead of waiting for the data source to be created (in this case the SampleInstructions.txt file on C:\) the unit tests can use Ninject to instantiate the InstructionProcessor with string values with any delimiter that is a char[] and test the creation of instructions and the processing of instructions and thus the final result.