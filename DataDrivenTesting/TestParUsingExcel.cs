using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using AspectInjector.Broker;
using NUnit.Framework.Interfaces;
using NUnit.Framework;

namespace TestProjectNunitTraining.DataDrivenTesting
{
    internal class TestParUsingExcel
    {
        [Test, TestCaseSource("GetTestdata")]
        public void Logintest(string username, string password)
        {
            Console.WriteLine(username + " " + password);
        }
        public static IEnumerable<TestCaseData> GetTestdata()
        {
            var columns = new List<string> { "username", "password" };
            return NUnitSeleniumC_Training.Utilities.ExcelRead.GetTestDataFromExcel("C:\\Users\\ubhat\\source\\repos\\TestProjectNunitTraining\\TestProjectNunitTraining\\testdata.xlsx","LoginTest", columns);
        }
    }
}
