using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BRIT.Calculator.Abstract
{
    public interface ICalculator
    {
        decimal AddNumbers(decimal numberOne, decimal numberTwo);
        decimal SubtractNumbers(decimal numberOne, decimal numberTwo);
        decimal MultiplyNumbers(decimal numberOne, decimal numberTwo);
        decimal DivideNumbers(decimal numberOne, decimal numberTwo);
    }
}
