using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using CSharpTests;
using Microsoft.VisualStudio.TestTools.UnitTesting;
namespace CSharpTests.Tests
{
    [TestClass()]
    public class StringPermutationsTests
    {
        [TestMethod()]
        public void GetPermutationsTest()
        {
            //Arrange
            List<string> expected = new List<string>() { "abc", "acb", "bac", "bca", "cab", "cba" };
            List<string> actual = null;

            //Act
            actual = StringPermutations.GetPermutations("abc");


            //Assert
            CollectionAssert.AreEquivalent(expected, actual);
        }
    }
}
