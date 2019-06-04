using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using Weather.Core.Units;

namespace Weather.Providers.Tests
{
    [TestClass]
    public class DirectionParserTests
    {
        [TestMethod]
        public void TestCardinalPoints()
        {
            Assert.AreEqual(Direction.North, DirectionParser.FromDegrees(0));
            Assert.AreEqual(Direction.East, DirectionParser.FromDegrees(90));
            Assert.AreEqual(Direction.South, DirectionParser.FromDegrees(180));
            Assert.AreEqual(Direction.West, DirectionParser.FromDegrees(270));
        }

        [TestMethod]
        public void TestIntercardinalPoints()
        {
            Assert.AreEqual(Direction.NorthEast, DirectionParser.FromDegrees(45));
            Assert.AreEqual(Direction.SouthEast, DirectionParser.FromDegrees(135));
            Assert.AreEqual(Direction.SouthWest, DirectionParser.FromDegrees(225));
            Assert.AreEqual(Direction.NorthWest, DirectionParser.FromDegrees(315));
        }

        [TestMethod]
        public void TestIntermediateValues()
        {
            Assert.AreEqual(Direction.North, DirectionParser.FromDegrees(20));
            Assert.AreEqual(Direction.East, DirectionParser.FromDegrees(100));
            Assert.AreEqual(Direction.South, DirectionParser.FromDegrees(190));
            Assert.AreEqual(Direction.West, DirectionParser.FromDegrees(280));

            Assert.AreEqual(Direction.NorthEast, DirectionParser.FromDegrees(55));
            Assert.AreEqual(Direction.SouthEast, DirectionParser.FromDegrees(145));
            Assert.AreEqual(Direction.SouthWest, DirectionParser.FromDegrees(235));
            Assert.AreEqual(Direction.NorthWest, DirectionParser.FromDegrees(325));
        }
    }
}
