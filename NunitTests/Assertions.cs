using System;
using System.Collections.Generic;
using System.Diagnostics.CodeAnalysis;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TestProjectNunitTraining.NunitTests
{
    internal class Assertions
    {
        [Test]
        public void AssertionEg()
        {
            string actual = "google";
            
            string expected = "yahoo";
            if (actual == expected)
            {
                Console.WriteLine("The results are matching");
            }
            else
            {
                Console.WriteLine("The results are not matching");

            }
            //Assert.AreEqual(actual, expected);//fail
            Assert.AreNotEqual(actual, expected);// pass
            //Assert.AreSame(actual, expected);//fail
            Assert.AreNotSame(actual, expected);//pass

            //assert.that
            //Assert.That(actual, Is.EqualTo(expected));
            Assert.That(actual, Is.Not.EqualTo(expected));

            //assert for strings with ignore case
            //Assert.That(actual, Is.EqualTo(expected).IgnoreCase);

            //substring
            Assert.That(actual, Does.Contain("goo").IgnoreCase);

            //empty assertion
            //Assert.IsTrue(actual.Equals(expected));
            //Assert.IsEmpty(actual); ;
            //Assert.IsNull(actual); 
            Assert.IsNotNull(actual);
            //Assert.AreEqual(expected, actual);

            //Collection constraints
            int[] array = new int[] { 1, 2, 3, 4, 5, 6 };
            Assert.NotNull(array);
            Assert.That(array, Is.All.GreaterThan(0));
            //Assert.IsEmpty(array);
            Assert.That(array, Is.Ordered.Ascending);
            int age = 17;
            if(age<18)
            {
                //throw new AssertionException("User is not eligible");
            }



        }
    }
}
