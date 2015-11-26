using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using BRIT.Calculator.Abstract;

namespace BRIT.Calculator
{
    public class FunkyCalc : ICalculator
    {        
        public decimal AddNumbers(decimal numberOne, decimal numberTwo)
        {
            return (numberOne + numberTwo);
        }

        public decimal SubtractNumbers(decimal numberOne, decimal numberTwo)
        {
            return (numberOne - numberTwo);
        }

        public decimal MultiplyNumbers(decimal numberOne, decimal numberTwo)
        {
            return (numberOne * numberTwo);
        }

        public decimal DivideNumbers(decimal numberOne, decimal numberTwo)
        {
            return (numberOne / numberTwo);
        }
    }
}
