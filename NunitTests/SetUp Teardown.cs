using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TestProjectNunitTraining.NunitTests
{
    internal class SetUp_Teardown
    {
        [SetUp]
        public void launchbrowser()
        {
            Console.WriteLine("Launching the browser");
        }
        //[SetUp, Order(1)]
        //public void dbconnection()
        //{
        //    Console.WriteLine("Db connection opened");
        //}

        [TearDown]
        public void closebrowser()
        {
            Console.WriteLine("Closing the browser");


        }
        [Test, Order(1)]
        public void userreg()
        {
            Console.WriteLine("User registration completed");
        }
        [Test, Order(2)]
        public void userlog()
        {
            Console.WriteLine("User is logged in");
        }

        [Test, Order(3)]
        public void products()
        {
            Console.WriteLine("User selects the product");
        }
    }
}
