using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;
using BRIT.Calculator.Entities;
using BRIT.Calculator.Framework;

namespace BRIT.Calculator
{
    class Program
    {
        static void Main(string[] args)
        {
            
            try
            {
                //Pass the file path and file name to the StreamReader constructor
                StreamReader sr = new StreamReader("C:\\SampleInstructions.txt");
                NinjectFactory ninjectFactory = new NinjectFactory();
                var processor = ninjectFactory.GetInstructionProcessor(new char[0]);
                
                String line;
                Instruction instruction;
                List<Instruction> instructions = new List<Instruction>();

                //Read the first line of text
                line = sr.ReadLine();

                //Continue to read until you reach end of file
                while (line != null)
                {
                    instruction = new Instruction();
                    instruction = processor.GetInstruction(line);
                    instructions.Add(instruction);

                    //Read the next line
                    line = sr.ReadLine();
                }

                decimal result = processor.ProcessInstructions(instructions);
                
                //close the file
                sr.Close();
                Console.WriteLine(result);
                Console.ReadLine();
            }
            catch (Exception e)
            {
                Console.WriteLine("Exception: " + e.Message);
            }
            finally
            {
                Console.WriteLine("Executing finally block.");
            }
        }
    }
}
