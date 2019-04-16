using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using NUnit.Framework;
using MTDClasses;

namespace MTDTests
{
    [TestFixture]
    public class BoneYardTests
    {
        BoneYard boneYard;
        BoneYard boneYardOverloaded;
        BoneYard boneNeg1;
        BoneYard bone1;
        int maxDots = 12;

        [SetUp]
        public void SetUpAllTests()
        {
            boneYard = new BoneYard(0);
            boneYardOverloaded = new BoneYard(maxDots);
            boneNeg1 = new BoneYard(-1);
            bone1 = new BoneYard(1);
        }
        [Test]
        public void TestSimpleAddition()
        {
            int math = 1 + 2;
            Assert.AreEqual(3, math);
        }
        [Test]
        public void TestOverloadedConstructor()
        {
            Assert.AreEqual(1, boneYard.DominosRemaining);
            Assert.AreEqual(91, boneYardOverloaded.DominosRemaining);
            Assert.AreEqual(0, boneNeg1.DominosRemaining);
            Assert.AreEqual(3, bone1.DominosRemaining);
        }
        [Test]
        public void TestBoneYardShuffle()
        {
            boneYardOverloaded.Shuffle();
            Domino firstDomino = boneYardOverloaded[0];
            Assert.AreNotEqual(0, firstDomino.Side1);
            Assert.AreNotEqual(0, firstDomino.Side2);
        }
        [Test]
        public void TestBoneyardIsEmpty()
        {
            Assert.AreEqual(false, boneYardOverloaded.IsEmpty());
            Assert.AreEqual(true, boneNeg1.IsEmpty());
        }
        [Test]
        public void TestDominosRemaining()
        {
            Assert.AreEqual(1, boneYard.DominosRemaining);
            Assert.AreEqual(91, boneYardOverloaded.DominosRemaining);
            Assert.AreEqual(0, boneNeg1.DominosRemaining);
            Assert.AreEqual(3, bone1.DominosRemaining);
        }
        [Test]
        public void TestBoneyardDraw()
        {
            Domino firstDomino = boneYardOverloaded.Draw();
            Domino secondDomino = boneYardOverloaded.Draw();
            Assert.AreEqual(0, firstDomino.Side1);
            Assert.AreEqual(0, firstDomino.Side2);
            Assert.AreEqual(0, secondDomino.Side1);
            Assert.AreEqual(1, secondDomino.Side2);
        }
    }
}
