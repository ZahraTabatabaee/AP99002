using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace C6.Test
{
    [TestClass]
    public class ShapeTest
    {
        [TestMethod]
        public void UpdateCornerAndGetCornerTest()
        {
            Point p = new Point{X=1,Y=2};
            Shape s = new Shape("window",4);
            s.UpdateCorner(0,p);
            p.X = 2;
            s.UpdateCorner(1,p);
            p.Y = 6;
            s.UpdateCorner(2,p);
            p.X=0;p.Y=-2;
            s.UpdateCorner(3,p);
            p.X=2;p.Y=6;
            Assert.AreEqual(s.GetCorner(2),p);
            p.X=2;p.Y=2;
            Assert.AreEqual(s.GetCorner(1),p);
        }
        [TestMethod]
        public void ExchangeCornerTest()
        {
            Point p = new Point{X=1,Y=2};
            Shape s = new Shape("triangle",3);
            s.UpdateCorner(0,p);
            p.X = 2;
            s.UpdateCorner(1,p);
            p.Y = 3;
            s.UpdateCorner(2,p);
            Assert.AreEqual(s.GetCorner(2),p);
            s.ExchangeCorners(1,2);
            Assert.AreEqual(s.GetCorner(1),p);
            p.X = 4;p.Y=4;
            s.UpdateCorner(0,p);
            Assert.AreEqual(s.GetCorner(0),p);
        }
        [TestMethod]
        public void SwitchXYTest()
        {
            Point p = new Point{X=2,Y=3};
            Shape s = new Shape("triangle",3);
            s.UpdateCorner(0,p); //(2,3)
            p.X = 3;
            s.UpdateCorner(1,p); //(3,3)
            p.Y = 6;
            s.UpdateCorner(2,p); //(3,6)
            s.SwitchXY(ref p);
            s.UpdateCorner(2,p);
            Assert.AreEqual(s.GetCorner(2).X,6);
            Assert.AreEqual(s.GetCorner(2).Y,3);
        }
    }
}
