﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TestProjectNunitTraining.DataDrivenTesting
{
    internal class TestParUsingTestcase
    {
        [TestCase(12, 3, 4)]
        [TestCase(12, 2, 6)]
        [TestCase(12, 4, 3)]
        public void DivideTest(int n, int d, int q)
        {
            Assert.That(n / d, Is.EqualTo(q));
        }

    }
}
