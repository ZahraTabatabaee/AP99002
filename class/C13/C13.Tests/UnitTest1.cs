using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace C13.Tests
{
    [TestClass]
    public class UnitTest1
    {
        [TestMethod]
        public void xCompare()
        {
            Point[] points = new Point[] {
                new Point(0,0),
                new Point(9,4),
                new Point(7,8),
                new Point(2,10),
                new Point(11,1),
                new Point(1,2),
                new Point(10,7),
            };
            Program.Sort<Point>(points , (a,b)=>a.X<b.X);
            int[] res = new int[] {11,10,9,7,2,1,0};
            for(int i = 0 ; i < 7 ; i++ ){
                Assert.AreEqual(points[i].X , res[i]);
            }
        }
        [TestMethod]
        public void yCompare()
        {
            Point[] points = new Point[] {
                new Point(0,0),
                new Point(9,4),
                new Point(7,8),
                new Point(2,10),
                new Point(11,1),
                new Point(1,2),
                new Point(10,7),
            };
            Program.Sort<Point>(points , (a,b)=>a.Y<b.Y);
            int [] res = new int[] {10,8,7,4,2,1,0};
            for(int i = 0 ; i < 7 ; i++ ){
                Assert.AreEqual(points[i].Y , res[i]);
            }

        }
        [TestMethod]
        public void MagnitudeComapare()
        {
            Point[] points = new Point[] {
                new Point(0,0),
                new Point(4,3),
                new Point(0,2),
                new Point(6,8)
            };
            Program.Sort<Point>(points , (a,b)=>a.MagnitudeComparer <b.MagnitudeComparer );
            double[] res =new double[] {10,5,2,0};
            for(int i = 0 ; i<4 ; i++){
                Assert.AreEqual(points[i].MagnitudeComparer , res[i]);
            }
        }
    }
}
