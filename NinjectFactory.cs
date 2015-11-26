using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Ninject;
using Moq;
using BRIT.Calculator.Abstract;
using BRIT.Calculator.Framework;

namespace BRIT.Calculator
{
    public class NinjectFactory
    {
        private IKernel ninjectKernel;

        public NinjectFactory()
        {
            ninjectKernel = new StandardKernel();            
        }

        public IInstructionProcessor GetInstructionProcessor(char[] arguments)
        {
            ninjectKernel.Bind<IInstructionProcessor>().To<InstructionProcessor>().WithConstructorArgument("delimiter", arguments);
            var instructionProcessor = ninjectKernel.Get<IInstructionProcessor>();
            return instructionProcessor;
        }

    }
}
