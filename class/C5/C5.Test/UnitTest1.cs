using Microsoft.VisualStudio.TestTools.UnitTesting;
namespace C5.test
{
    [TestClass]
    public class UnitTest1
    {
        [TestMethod]
        public void TestMethod1()
        {
            Point p = new Point(5, 2, 3);
            Point p1 = new Point(4, 4, 5);

            Assert.AreEqual(Point.DistanceTo(p, p), 0);
            Assert.AreEqual(Point.DistanceTo(p1,p), 3);
            Assert.AreEqual(p.DistanceTo(p1),3);

            PointValue p2 = new PointValue(5, 2, 3);
            PointValue p3 = new PointValue(4, 4, 5);

            Assert.AreEqual(PointValue.DistanceTo(p2,p2), 0);
            Assert.AreEqual(PointValue.DistanceTo(p3,p2), 3);
            Assert.AreEqual(p2.DistanceTo(p3),3);
        }
    }
}

