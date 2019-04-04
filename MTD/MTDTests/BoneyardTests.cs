using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using MTDClasses;
using NUnit.Framework;

namespace MTDTests
{
    [TestFixture]
    public class BoneyardTests
    {
        [Test]
        public void TestConstructor()
        {
            Boneyard b6 = new Boneyard(6);
            Assert.AreEqual(28, b6.dListRemaining);
            Assert.AreEqual(new Domino(0, 0), b6[0]);
            Assert.AreEqual(new Domino(6, 6), b6[27]);
            Assert.AreEqual(new Domino(1, 1), b6[7]);
        }
    }
}
