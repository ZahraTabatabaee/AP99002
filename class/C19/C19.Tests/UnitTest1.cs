using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace C19.Tests
{
    [TestClass]
    public class UnitTest1
    {
        [TestMethod]
        public void Multiplyop()
        {
            Complex c1 = new Complex(1,1);
            Complex c2 = new Complex(2,2);
            Complex c3 =c1 * c2;
            double img = 4 ;
            double real = 0 ;
            Assert.AreEqual(c3.Img , img);
            Assert.AreEqual(c3.Real , real);
        }

        [TestMethod]
        public void Equalsmethod()
        {
            Complex c1 = new Complex(1,1);
            Complex c2 = new Complex(2,2);
            Complex c3 = new Complex(2,2);
            Assert.AreEqual(false,c1.Equals(c2));
            Assert.AreEqual(false, c1.Equals(c3));
            Assert.AreEqual(true,c2.Equals(c3));
            Assert.AreEqual(true,c1.Equals("1i+1"));
            Assert.AreEqual(false,c2.Equals("1i+1"));
            Assert.AreEqual(true,c3.Equals("2i+2"));
        }

        [TestMethod]
        public void EqualityOps()
        {
            Complex c1 = new Complex(1,1);
            Complex c2 = new Complex(2,2);
            Complex c3 = new Complex(2,2);
            Assert.IsTrue(c1!=c2);
            Assert.IsTrue(c1!=c3);
            Assert.IsTrue(c2==c3);
            Assert.IsFalse(c1==c2);
            Assert.IsFalse(c1==c3);
            Assert.IsFalse(c2!=c3);
        }

        [TestMethod]
        public void ToStringMethod(){
            Complex c = new Complex(1,2);
            Assert.AreEqual(c.ToString(),"1i+2");
        }

        [TestMethod]
        public void ExplicitOpString()
        {
            string result = (string) new Complex(1,2);
            Assert.AreEqual(result , "1i+2");
        }

        [TestMethod]
        public void ExplicitOpComplex()
        {
            Complex c = (Complex) "1i+2";
            Assert.AreEqual(c.Img , 1);
            Assert.AreEqual(c.Real , 2);
        }
    }
}
