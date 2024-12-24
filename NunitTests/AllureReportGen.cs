using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TestProjectNunitTraining.NunitTests
{
    [Allure.NUnit.AllureNUnit]
    internal class AllureReportGen
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
        [Test]
        public void Addtocart()
        {
            Console.WriteLine("Cart is added");
        }
        [Test]
        public void payment()
        {
            Console.WriteLine("User payment completed");
        }
    }
}
