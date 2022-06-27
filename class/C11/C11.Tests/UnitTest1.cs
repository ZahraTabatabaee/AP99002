using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace C11.Tests
{
    [TestClass]
    public class UnitTest1
    {
        [TestMethod]
        public void TestTriangle()
        {
            Triangle T1 = new Triangle("t1",new Point(0,0),new Point(1,3),new Point(2,4));
            T1.Move(2,2);
            Assert.AreEqual(T1.p1.x , 2);
            Assert.AreEqual(T1.p2.x , 3);
            Assert.AreEqual(T1.p3.x , 4);
            Assert.AreEqual(T1.p1.y , 2);
            Assert.AreEqual(T1.p2.y , 5);
            Assert.AreEqual(T1.p3.y , 6);
        }
        [TestMethod]
        public void TestCircle()
        {
            Circle C1 = new Circle("c1",new Point(3,8),2);
            C1.Move(3,1);
            Assert.AreEqual(C1.p1.x,6);
            Assert.AreEqual(C1.p1.y,9);
        }
        [TestMethod]
        public void TestSquare()
        {
            Square S1 = new Square("s1",new Point(0,0),new Point(0,2),new Point(2,0),new Point(2,2));
            Assert.AreEqual(S1.p4.x , 2);
            Assert.AreEqual(S1.p2.x , 0);
            Assert.AreEqual(S1.p3.x , 2);
            Assert.AreEqual(S1.p4.y , 2);
            Assert.AreEqual(S1.p2.y , 2);
            Assert.AreEqual(S1.p3.y , 0);
            S1.Move(0,1);
            Assert.AreEqual(S1.p4.x , 2);
            Assert.AreEqual(S1.p2.x , 0);
            Assert.AreEqual(S1.p3.x , 2);
            Assert.AreEqual(S1.p4.y , 3);
            Assert.AreEqual(S1.p2.y , 3);
            Assert.AreEqual(S1.p3.y , 1);
            Assert.AreEqual(S1.p1.x , 0);
            Assert.AreEqual(S1.p1.y , 1);
        }
        [TestMethod]
        public void BoardAdd_Move(){
            Triangle T1 = new Triangle("t1",new Point(0,0),new Point(1,3),new Point(2,4));
            Circle C1 = new Circle("c1",new Point(3,8),2);
            Square S1 = new Square("s1",new Point(0,0),new Point(0,2),new Point(2,0),new Point(2,2));
            Board B1 = new Board();
            B1.AddShape(T1);
            B1.AddShape(C1);
            B1.AddShape(S1);
            Assert.AreEqual(B1.n_shapes.Count , 3);
            Assert.AreEqual(B1.n_shapes[1] , C1);
            B1.MoveAllShapes(0,1);
            Assert.AreEqual(C1.p1.y, 9);
            Assert.AreEqual(S1.p3.y, 1);
        }
        [TestMethod]
        public void EnumerableBoard()
        {
            Triangle T1 = new Triangle("t1",new Point(0,0),new Point(1,3),new Point(2,4));
            Triangle T2 = new Triangle("t1",new Point(0,0),new Point(1,3),new Point(2,4));
            Triangle T3 = new Triangle("t1",new Point(0,0),new Point(1,3),new Point(2,4));
            Board B1 = new Board();
            B1.AddShape(T1);
            B1.AddShape(T2);
            B1.AddShape(T3);
            int x = 0;
            foreach(IShape s in B1){
                Assert.AreEqual(s.ToString(),"Triangle");
                x++;
            }
            Assert.AreEqual(x,3);

            Board B2 = new Board();
            Circle C1 = new Circle("c1",new Point(3,8),2);
            Circle C2 = new Circle("c1",new Point(3,8),2);
            B2.AddShape(C1);
            B2.AddShape(C2);
            int y = 0;
            foreach(IShape s in B2){
                Assert.AreEqual(s.ToString(),"Circle");
                y++;
            }
            Assert.AreEqual(y,2);
        }
    }
}
