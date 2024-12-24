using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TestProjectNunitTraining.NunitTests
{
    [Parallelizable(ParallelScope.All)]
    internal class ParallelExecution
    {
        [Test]
        public void userreg()
        {
            Console.WriteLine("User registration completed");
        }
        [Test]
        public void userlog()
        {
            Console.WriteLine("User is logged in");
        }

        [Test]
        public void products()
        {
            Console.WriteLine("User selects the product");
        }
    }
}
