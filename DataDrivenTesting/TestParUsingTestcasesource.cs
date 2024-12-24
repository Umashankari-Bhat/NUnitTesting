using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using NUnit.Framework;

namespace TestProjectNunitTraining.DataDrivenTesting
{
    internal class TestParUsingTestcasesource
    {
        [Test, TestCaseSource("GetTestdata")]
        public void Logintest(string username, string password)
        {
            Console.WriteLine(username + " " + password);
        }
        public static IEnumerable<TestCaseData> GetTestdata()
        {
            yield return new TestCaseData("abc.com", "gghh");
            yield return new TestCaseData("xvb.com", "eweer");
            yield return new TestCaseData("ikk.com", "eretr");
            yield return new TestCaseData("kmii.com", "eettr");
        }

    }
}
