using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using NUnit.Framework;
using System.Threading.Tasks;

namespace SimpleMath.Test
{
    [TestFixture]
    //Test Code
    public class GitTesting1Test
    {
        [TestCase]
        public void AddTest()
        {
            SimpleMath.MathsHelper helper = new SimpleMath.MathsHelper();
            int result = helper.Add(20, 10);
            Assert.AreEqual(30, result);
        }
        [TestCase]
        public void SubtractTest()
        {
            SimpleMath.MathsHelper helper = new SimpleMath.MathsHelper();
            int result = helper.Subtract(20, 10);
            Assert.AreEqual(10, result);
        }
    }
}
