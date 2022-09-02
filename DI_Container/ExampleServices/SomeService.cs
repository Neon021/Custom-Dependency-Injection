using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DI_Container.ExampleServices
{
    public class SomeService : ISomeService
    {
        //private readonly Guid guid = Guid.NewGuid();

        private readonly IRandomGuidGenerator _guidGenerator;

        public SomeService(IRandomGuidGenerator guidGenerator)
        {
            _guidGenerator = guidGenerator;
        }

        public void DoSmthng()
        {
            Console.WriteLine(_guidGenerator.randomguid);
        }
    }
}
