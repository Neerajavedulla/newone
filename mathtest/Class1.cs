using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using NUnit.Framework;
using ConsoleApplication2;
namespace mathtest
{
    [TestFixture]
    public class Class1
    {
        [Test]
        public void addtest()
        {
            mathhelper obj = new mathhelper();
            int result = obj.add(20, 10);
            int expert = 30;
            Assert.AreEqual(expert, result);
        }

    }
}
