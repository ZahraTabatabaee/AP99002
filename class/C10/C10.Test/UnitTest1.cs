using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace C10.Test
{
    [TestClass]
    public class UnitTest1
    {
        public void XCompare()
        {
            Point[] points = new Point[] {
                new Point(0,0),
                new Point(1,5),
                new Point(2,6),
                new Point(8,10),
                new Point(5,1),
                new Point(12,2),
                new Point(3,7),
            };
            Program.Sort<Point>(points , PointComparer.PointXComparer );
            int[] result = new int[] {12,8,5,3,2,1,0};
            for(int i = 0 ; i < 7 ; i++ ){
                Assert.AreEqual(points[i].X , result[i]);
            }
        }
        [TestMethod]
        public void YCompare()
        {
            Point[] points = new Point[] {
                new Point(0,0),
                new Point(1,5),
                new Point(2,6),
                new Point(8,10),
                new Point(5,1),
                new Point(12,2),
                new Point(3,7),
            };
            Program.Sort<Point>(points , PointComparer.PointYComparer );
            int [] result = new int[] {10,7,6,5,2,1,0};
            for(int i = 0 ; i < 7 ; i++ ){
                Assert.AreEqual(points[i].Y, result[i]);
            }

        }
        [TestMethod]
        public void MagnitudeComapare()
        {
            Point[] points = new Point[] {
                new Point(0,0),
                new Point(3,4),
                new Point(5,12),
                new Point(0,1)
            };
            Program.Sort<Point>(points , PointComparer.PointMagnitudeComparer);
            double[] result =new double[] {13,5,1,0};
            for(int i = 0 ; i<4 ; i++){
                Assert.AreEqual(points[i].MagnitudeComparer , result[i]);
            }
        }
    }
}
