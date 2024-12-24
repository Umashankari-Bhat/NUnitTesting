using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TestProjectNunitTraining.NunitTests
{
    internal class TestOrder
    {
        [Test,Order(1)]
        public void userreg()
        {
            Console.WriteLine("User registration completed");
        }
        [Test,Order(2)]
        public void userlog()
        {
            Console.WriteLine("User is logged in");
        }

        [Test,Order(3)]
        public void products()
        {
            Console.WriteLine("User selects the product");
        }
        [Test,Order(4)]
        public void Addtocart()
        {
            Console.WriteLine("Cart is added");
        }
        [Test,Order(5)]
        public void payment()
        {
            Console.WriteLine("User payment completed");
        }
    }
}
