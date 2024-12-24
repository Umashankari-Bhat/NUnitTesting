using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TestProjectNunitTraining.NunitTests
{
    internal class Categories
    {
        [Test, Order(1), Category("Regression")]
        public void userreg()
        {
            Console.WriteLine("User registration completed");
        }
        [Test, Order(2), Category("Sanity")]
        public void userlog()
        {
            Console.WriteLine("User is logged in");
        }

        [Test, Order(3), Category("Regression")]
        public void products()
        {
            Console.WriteLine("User selects the product");
        }
        [Test, Order(4), Category("Regression")]
        public void Addtocart()
        {
            Console.WriteLine("Cart is added");
        }
        [Test, Order(5), Category("Sanity")]
        public void payment()
        {
            Console.WriteLine("User payment completed");
        }
    }
}
