using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TestProjectNunitTraining.NunitTests
{
    internal class Test2
    {
        [Test, Description("First case")]
        public void test1()
        {
            Console.WriteLine("Second test case is executed");

        }
    }
}
