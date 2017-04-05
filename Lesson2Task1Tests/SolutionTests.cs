using Microsoft.VisualStudio.TestTools.UnitTesting;
using Lesson2Task1;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lesson2Task1.Tests
{
    [TestClass()]
    public class SolutionTests
    {
        [TestMethod()]
        public void solutionTest()
        {
            var A = new[] {9, 3, 9, 3, 7, 5, 5, 9, 9};
            Solution sol = new Solution();
            var test = sol.solution(A);

            Assert.AreEqual(7, test);
        }
    }
}